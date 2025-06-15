using DynamicCv.Models.Entity;
using DynamicCv.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class AdminController : Controller
    {
        GenericRepository<TblLogin> repo = new GenericRepository<TblLogin>();

        public IActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(TblLogin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAdmin(int id)
        {
            TblLogin t = repo.Find(x => x.Id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAdmin(int id)
        {
            TblLogin t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditAdmin(TblLogin p)
        {
            TblLogin t = repo.Find(x => x.Id == p.Id);
            t.Username = p.Username;
            t.Password = p.Password;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
