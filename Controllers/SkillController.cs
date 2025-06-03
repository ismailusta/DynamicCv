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
            var yetenekler = repo.List;
            return View(yetenekler);
        }
    }
}
