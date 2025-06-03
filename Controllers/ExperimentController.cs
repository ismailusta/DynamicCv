using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using DynamicCv.Repositories;


namespace DynamicCv.Controllers
{
    public class ExperimentController : Controller
    {
        ExperienceRepository repo = new ExperienceRepository();
        public IActionResult Index()
        {
            var deneyimler = repo.List();
            return View(deneyimler);
        }
        [HttpGet]
        public IActionResult AddExperiment() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperiment(TblExperience p) 
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperiment(int id) 
        {
            TblExperience t = repo.Find(x=>x.Id==id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperiment(int id)
        {
            TblExperience t = repo.Find(x=> x.Id==id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditExperiment(TblExperience p)
        {
            TblExperience t = repo.Find(x => x.Id == p.Id);
            t.Title = p.Title;
            t.SubTitle = p.SubTitle;
            t.Description = p.Description;
            t.Date = p.Date;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
