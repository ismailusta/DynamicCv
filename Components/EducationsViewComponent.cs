using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;


namespace DynamicCv.Components
{
    public class EducationsViewComponent : ViewComponent
    {
        private readonly CvContext _context;
        public EducationsViewComponent(CvContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke() 
        {
            var educations = _context.TblEducations.ToList();
            return View("Education",educations);
        }
    }
}
