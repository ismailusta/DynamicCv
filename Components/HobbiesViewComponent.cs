using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Components
{
    public class HobbiesViewComponent : ViewComponent
    {
        private readonly CvContext _context;
        public HobbiesViewComponent(CvContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke() 
        {
            var hobbies = _context.TblHobbies.ToList();
            return View("Hobbie",hobbies);
        }
    }
}
