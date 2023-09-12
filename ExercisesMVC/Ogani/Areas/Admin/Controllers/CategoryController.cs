using Microsoft.AspNetCore.Mvc;
using Ogani.Data;
using Ogani.Data.Entities;

namespace Ogani.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }


       [HttpGet]
       public IActionResult Details(Guid? id)
        {
            if (id is null ) 
            { 
                return RedirectToAction("Categories","Console");
            }
            else
            {
                 Category? category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
                if (category == null)
                {
                    return RedirectToAction("Categories", "Console");
                }
                else
                {
                     return View(category);

                }

            }

        }

        [HttpGet]
        public IActionResult Create()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Create(Category? category)
        {
            if (category == null)
            {
                return RedirectToAction("Categories","Console");
            }
            else
            {
                try
                {
                Category newCategory = new Category(category.CategoryName, category.CategoryDescription);
                    _context.Categories.Add(newCategory);
                    _context.SaveChanges();

                    return RedirectToAction("Categories", "Console");

                }
                catch (Exception ex)
                {

                    return RedirectToAction("Error", "Console",ex);
                }
            }
        }


    }
}
