using DynamicCv.Models.Entity;
using DynamicCv.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        CvContext db = new CvContext();
        public IActionResult Index()
        {
            var viewModel = new AboutSocialViewModel
            {
                TblAbouts = db.TblAbouts.ToList(),
                TblSocialMedia = db.TblSocials.ToList(),
            };
            return View(viewModel);
        }
    }
}
