using DynamicCv.Models.Entity;
using DynamicCv.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class SocialMediaController : Controller
    {
        GenericRepository<TblSocialMedia> repo = new GenericRepository<TblSocialMedia>();
        public IActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            TblSocialMedia t = repo.Find(x=>x.Id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddSocialMedia() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(TblSocialMedia p) 
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id) 
        {
            TblSocialMedia t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(TblSocialMedia p)
        {
            TblSocialMedia t = repo.Find(x =>x.Id == p.Id);
            t.AppName = p.AppName;
            t.Icon= p.Icon;
            t.Link= p.Link;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
