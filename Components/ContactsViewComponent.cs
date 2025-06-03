using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Components
{
    public class ContactsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Contact", new TblContact());

        }
    }
}
