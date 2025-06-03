using DynamicCv.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicCv.Controllers
{
    public class ContactController : Controller
    {
        private readonly CvContext _context;
        public ContactController(CvContext context)
        {
            _context = context;            
        }
        [HttpPost]
        public IActionResult SendMessage(TblContact contact) 
        {
            contact.Date = DateTime.Now.ToString();
            _context.TblContacts.Add(contact);
            _context.SaveChanges();
            TempData["Message"] = "Mesajınız başarıyla gönderildi.";
            return RedirectToAction("Index", "Default");
        }
    }
}
