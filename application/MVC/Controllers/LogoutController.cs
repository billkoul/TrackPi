using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace trackpi.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.SignOutAsync(Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index", "login");
        }
    }
}