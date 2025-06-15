using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DynamicCv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(TblLogin p)
        {
            CvContext c = new CvContext();
            var loginMan = c.TblLogins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);

            if (loginMan != null)
            {
                // Kullanıcı bilgileriyle Claim oluştur
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, loginMan.Username)
                };

                // ClaimsIdentity ile kimlik oluştur
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // ClaimsPrincipal ile kullanıcı bilgilerini sar
                var principal = new ClaimsPrincipal(identity);

                // Kimlik doğrulama çerezi oluştur
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "About");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View(); // Redirect değil, yeniden formu gösteriyoruz
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
