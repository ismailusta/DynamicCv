using DynamicCv.Models.Entity;
using DynamicCv.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class ContactController : Controller
    {
        GenericRepository<TblContact> repo = new GenericRepository<TblContact>();
        public IActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}
