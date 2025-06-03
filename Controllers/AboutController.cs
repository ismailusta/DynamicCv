using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
