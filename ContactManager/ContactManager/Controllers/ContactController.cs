using ContactManager.Data;
using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;


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
            Contacts newContacts = new Contacts();
            return View(newContacts);
        }


        [HttpPost]
        public  IActionResult Add(Contacts contact)
        {
            if (ModelState.IsValid) // Check if model validation passed
            {
                try
                {
                    _db.Contacts.Add(contact);
                    _db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    // Handle exceptions, log the error, and provide feedback to the user.
                    ModelState.AddModelError("", "An error occurred while saving the contact.");
                    // You can also log the exception for debugging purposes.
                }
            }

            // If validation fails or an error occurs, redisplay the form with validation errors.
            return View(contact);
        }

        public IActionResult Delete(int id)
        {
            var contactToDelete=_db.Contacts.Find(id);

            if (contactToDelete == null)
            {
                return NotFound();
            }

            _db.Contacts.Remove(contactToDelete);
            _db.SaveChanges();  
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public  IActionResult Edit(int id)
        {
          
            var product = _db.Contacts.Find(id);
            if (product == null)
            {
                return NotFound();

            }

            return View(product);

        }

        [HttpPost]
        public IActionResult Edit(Contacts editedContact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingContact = _db.Contacts.Find(editedContact.Id);

                    if (existingContact == null)
                    {
                        return NotFound();
                    }

                    existingContact.FirstName = editedContact.FirstName;
                    existingContact.LastName = editedContact.LastName;
                    existingContact.Email = editedContact.Email;

                    _db.Contacts.Update(existingContact);
                    _db.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    // Handle exceptions, log the error, and provide feedback to the user.
                    ModelState.AddModelError("", "An error occurred while updating the contact.");
                    // You can also log the exception for debugging purposes.
                }
            }

            // If validation fails or an error occurs, redisplay the form with validation errors.
            return View(editedContact);
        }
    







    }
}
