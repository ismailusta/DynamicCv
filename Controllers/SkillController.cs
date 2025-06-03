using Microsoft.AspNetCore.Mvc;
using DynamicCv.Models.Entity;
using DynamicCv.Repositories;

namespace DynamicCv.Controllers
{
    public class SkillController : Controller
    {
        GenericRepository<TblSkill> repo = new GenericRepository<TblSkill>();
        public IActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(TblSkill p) 
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            TblSkill t = repo.Find(x => x.Id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id) 
        {
            TblSkill t = repo.Find(x =>x.Id == id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditSkill(TblSkill p) 
        {
            TblSkill t = repo.Find(x => x.Id == p.Id);
            t.Skill = p.Skill;
            t.Progress = p.Progress;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
