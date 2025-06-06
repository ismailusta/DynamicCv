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
    }
}
