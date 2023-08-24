using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApk2.Data;
using WebApk2.Models;

namespace WebApk2.Controllers
{
    public class CategoryController : Controller
    {

        private readonly Aplication2DbContext _db;


        public CategoryController(Aplication2DbContext db)
        {
            _db=db;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            IEnumerable<Category> categories = _db.Categories;
            return View(categories);
        }


        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Category item)
        {
            if (item.Name == item.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "The DisplayOrder cannot exactly match the Name");
            }
            {



                if (ModelState.IsValid)
                {
                    _db.Categories.Add(item);
                    _db.SaveChanges();
                }


                return View(item);
            }

        }



        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Edit(int? id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.Categories.Find(id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category item)
        {
            if (item.Name == item.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "The DisplayOrder cannot exactly match the Name");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Update(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);  
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
