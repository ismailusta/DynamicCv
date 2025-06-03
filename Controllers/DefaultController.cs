using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class DefaultController : Controller
    {
        CvContext db = new CvContext(); 
        public IActionResult Index()
        {
            var degerler = db.TblAbouts.ToList();
            return View(degerler);
        }
    }
}
