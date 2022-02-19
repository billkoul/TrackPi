using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MVVMViewModelLayer;
using trackpi.Models;
using MVVMDataLayer;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using MVVMEntityLayer;

namespace trackpi.Controllers
{
    [Authorize]
    public class LiveController : Controller
    {
        private readonly ILocationRepository _repo;
        private readonly LocationViewModel _viewModel;

        public LiveController(ILocationRepository repo, LocationViewModel vm)
        {
            _repo = repo;
            _viewModel = vm;
        }

        public IActionResult Index()
        {
            //get account devices
            ViewData["devices"] = HttpContext.Session.GetObject<List<Device>>("devices");

            int devId = HttpContext.Session.GetInt32("devId") ?? 0;
            _viewModel.Location = _repo.GetLast(devId);

            //get current device info
            ViewData["deviceName"] = devId;

            return View(_viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
