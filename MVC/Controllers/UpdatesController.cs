using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using trackpi.Models;
using MVVMDataLayer;
using Microsoft.AspNetCore.Http;
using MVVMViewModelLayer;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace trackpi.Controllers
{
    [Authorize]
    public class UpdatesController : Controller
    {
        private readonly IDeviceRepository _repo;
        private readonly DeviceViewModel _viewModel;
        private int _subId = 0;
        private HttpContext hcontext;

        public UpdatesController(IDeviceRepository repo, DeviceViewModel vm, IHttpContextAccessor haccess)
        {
            _repo = repo;
            _viewModel = vm;

            //get User info if still logged in but session expired
            hcontext = haccess.HttpContext;
            int.TryParse(hcontext.User?.FindFirst("subId").Value, out _subId);
        }

        public IActionResult Index()
        {
            //get devices for current subscription id
            int subId = HttpContext.Session.GetInt32("SubId") ?? _subId;
            _viewModel.Devices = _repo.Get(subId);

            //get account devices
            HttpContext.Session.SetObject("devices", _viewModel.Devices);
            ViewData["devices"] = _viewModel.Devices;

            //Set default device = first device
            if(_viewModel.Devices.Count > 0 && HttpContext.Session.GetInt32("devId") == null)
                HttpContext.Session.SetInt32("devId", _viewModel.Devices.FirstOrDefault().Id);

            //get current device info
            ViewData["deviceName"] = HttpContext.Session.GetInt32("devId") ?? 0;

            return View(_viewModel);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
