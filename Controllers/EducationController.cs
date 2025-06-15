using DynamicCv.Models.Entity;
using DynamicCv.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class EducationController : Controller
    {
        GenericRepository<TblEducation> repo = new GenericRepository<TblEducation> ();
        public IActionResult Index()
        {
            var egitimler = repo.List();
            return View(egitimler);
        }
        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(TblEducation p) 
        {
            if (!ModelState.IsValid) 
            {
                return View("AddEducation");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEducation(int id) 
        {
            TblEducation t = repo.Find(x => x.Id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            TblEducation t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditEducation(TblEducation p)
        {
            if(!ModelState.IsValid)
            {
                return View("EditEducation");
            }
            TblEducation t = repo.Find(x => x.Id == p.Id);
            t.Title = p.Title;
            t.SubTitle = p.SubTitle;
            t.Gno = p.Gno;
            t.Date = p.Date;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
