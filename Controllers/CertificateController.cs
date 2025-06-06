using DynamicCv.Models.Entity;
using DynamicCv.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class CertificateController : Controller
    {
        GenericRepository<TblCertificate> repo = new GenericRepository<TblCertificate>();
        public IActionResult Index()
        {
            var sertifikalar = repo.List();
            return View(sertifikalar);
        }
        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCertificate(TblCertificate p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCertificate(int id) 
        {
            TblCertificate t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public IActionResult EditCertificate(TblCertificate p)
        {
            TblCertificate t = repo.Find(x => x.Id == p.Id);
            t.Certificate=p.Certificate;
            t.Date=p.Date;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCertificate(int id)
        {
            TblCertificate t = repo.Find(x => x.Id == id);
            repo.TRemove(t);
            return RedirectToAction("Index");
        }
      
    }
}
