using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Data;
using SimpleMVC.Data.Entities;

namespace SimpleMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly SimpleMvcDbContext _db;
        public CategoryController(SimpleMvcDbContext db)
        {
            _db = db;
        }


        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            Category category = _db.Categories.FirstOrDefault(c => c.CategoryID == id);
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            Category category = _db.Categories.FirstOrDefault(c => c.CategoryID == id);
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                Category categoryToEdit = _db.Categories.FirstOrDefault(c => c.CategoryID == id);
                if (categoryToEdit != null)
                {
                    categoryToEdit.CategoryName = category.CategoryName;
                    categoryToEdit.CategoryDescription = category.CategoryDescription;
                    _db.Categories.Update(categoryToEdit);
                    _db.SaveChanges();
                }
                return RedirectToRoute("Start/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
