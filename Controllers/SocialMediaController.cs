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
    }
}
