using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MVVMViewModelLayer;
using trackpi.Models;
using MVVMDataLayer;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using MVVMEntityLayer;
using Newtonsoft.Json;

namespace trackpi.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class TripsController : Controller
    {
        private readonly ILocationRepository _repo;
        private readonly LocationViewModel _viewModel;

        public TripsController(ILocationRepository repo, LocationViewModel vm)
        {
            _repo = repo;
            _viewModel = vm;
        }

        public IActionResult Index()
        {
            //get account devices
            ViewData["devices"] = HttpContext.Session.GetObject<List<Device>>("devices");

            //get current device info
            ViewData["deviceName"] = HttpContext.Session.GetInt32("devId") ?? 0;

            int devId = HttpContext.Session.GetInt32("devId") ?? 0;
            _viewModel.Locations = _repo.Get(devId);

            return View(_viewModel);
        }

        [HttpPost]
        public IActionResult Filter(string formJson)
        {
            FormResponse formResponse = new FormResponse();

            var str = JsonConvert.DeserializeObject<string>(formJson);
            var formFilter = JsonConvert.DeserializeObject<TripFilter>(str);

            formResponse.Msg = "Ok";

            return Json(formResponse);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
