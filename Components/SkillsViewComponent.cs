using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;


namespace DynamicCv.Components
{
    public class SkillsViewComponent : ViewComponent
    {
        private readonly CvContext _context;
        public SkillsViewComponent(CvContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke() 
        {
            var skills =_context.TblSkills.ToList();
            return View("Skill",skills);
        }
    }
}
