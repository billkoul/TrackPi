using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVVMViewModelLayer;
using MVVMDataLayer;

namespace trackpi.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly IUserRepository _repo;
        private readonly UserViewModel _viewModel;

        public AccountController(IUserRepository repo, UserViewModel vm)
        {
            _repo = repo;
            _viewModel = vm;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("index", "home");
            else
                return RedirectToAction("index", "login");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Antiforgery()
        {
            return Content("Successful antiforgery!");
        }
    }
}
