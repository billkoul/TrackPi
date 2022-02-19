using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using MVVMViewModelLayer;
using MVVMDataLayer;
using MVVMEntityLayer;
using Microsoft.AspNetCore.Http;

namespace trackpi.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _repo;
        private readonly UserViewModel _viewModel;

        public LoginController(IUserRepository repo, UserViewModel vm)
        {
            _repo = repo;
            _viewModel = vm;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string ReturnUrl = HttpContext.Request.Query["ReturnUrl"].ToString();
            if (string.IsNullOrWhiteSpace(ReturnUrl)) ReturnUrl = "/";
            ViewData["ReturnUrl"] = ReturnUrl;

            if (User.Identity.IsAuthenticated)
                return RedirectToAction("index", "home");
            else
                return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLogin userLogin)
        {
            FormResponse formResponse = new FormResponse();

            try
            {
                UserLoginValidator userLoginValidator = new UserLoginValidator(userLogin.Username, userLogin.Password);
                userLogin.Password = userLoginValidator.HashPassword;

                User curUser = _repo.Login(userLogin);
                if (curUser != null)
                {
                    HttpContext.Session.SetInt32("SubId", curUser.SubscriptionId);

                    var claims = new List<Claim>
                    {
                        new Claim("subId", curUser.SubscriptionId.ToString()),
                    };

                    var userIdentity = new ClaimsIdentity(claims, "login");

                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    User.AddIdentity(userIdentity);

                    await HttpContext.SignInAsync(principal, new AuthenticationProperties
                    {
                        IsPersistent = true,
                        AllowRefresh = true,
                        ExpiresUtc = DateTime.UtcNow.AddDays(60)
                    });

                    formResponse.Msg = "Successful login.<br />Please wait redirecting...";
                }
                else
                {
                    formResponse.Result = 0;
                    formResponse.Msg = "Wrong username or password.<br />Please try again.";
                }
            }
            catch (Exception ex)
            {
                formResponse.Result = 0;
                formResponse.Msg = ex.Message;
            }

            return Json(formResponse);
        }
    }
}