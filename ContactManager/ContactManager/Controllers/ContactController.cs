using ContactManager.Data;
using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContactController(ApplicationDbContext db)
        {
           _db=db;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Contacts contact)
        {
          
            _db.Contacts.Add(contact);
            _db.SaveChanges();
            return View("Index");
        }
    }
}
