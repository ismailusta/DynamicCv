using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Components
{
    public class CertificationsViewComponent : ViewComponent
    {
        private readonly CvContext _context;
        public CertificationsViewComponent(CvContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var certifications = _context.TblCertificates.ToList();
            return View("Certificate",certifications);
        }
    }
}
