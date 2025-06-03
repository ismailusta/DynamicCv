using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;


namespace DynamicCv.ViewComponents
{
    public class ExperimentsViewComponent : ViewComponent
    {
        private readonly CvContext _context;

        public ExperimentsViewComponent(CvContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var experiences = _context.TblExperiences.ToList();
            return View("Experience",experiences);
        }
    }
}
