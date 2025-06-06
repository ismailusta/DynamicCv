using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class HobbieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
