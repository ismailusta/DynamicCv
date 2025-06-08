using DynamicCv.Models.Entity;
using DynamicCv.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class AboutController : Controller
    {
        GenericRepository<TblAbout> repo = new GenericRepository<TblAbout>();
        [HttpGet]
        public IActionResult Index()
        {
            var about = repo.List();
            return View(about);
        }
        [HttpPost]
        public IActionResult Index(TblAbout p)
        {
            TblAbout t = repo.Find(x => x.Id == 1);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.Address = p.Address;
            t.Phone = p.Phone;
            t.Email = p.Email;
            t.Photo = p.Photo;
            t.Description = p.Description;

            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

    }
}
