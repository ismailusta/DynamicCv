using DynamicCv.Models.Entity;
using DynamicCv.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class HobbieController : Controller
    {
        GenericRepository<TblHobby> repo = new GenericRepository<TblHobby>();
        public IActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpGet]
        public IActionResult AddHobbie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHobbie(TblHobby p) 
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteHobbie(int id) 
        {
            TblHobby t = repo.Find(x => x.Id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditHobbie(int id) 
        {
            TblHobby t = repo.Find(x =>x.Id == id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditHobbie(TblHobby p)
        {
            TblHobby t = repo.Find(x => x.Id ==  p.Id);
            t.Description1 = p.Description1;
            t.Description2 = p.Description2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

    }
}
