using Microsoft.AspNetCore.Mvc;
using WebApkTest1.Data;
using WebApkTest1.Models;

namespace WebApkTest1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AplicationDbContext _db;

        public CategoryController(AplicationDbContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {

            IEnumerable<Category> objCategoryList = _db.Categories;


            return View(objCategoryList);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category item)
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



        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.Categories.Find(id);
            
            if(categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category item)
        {
            if (item.Name == item.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "The DisplayOrder cannot exactly match the Name");
            }
            {



                if (ModelState.IsValid)
                {
                    _db.Categories.Update(item);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }


                return View(item);
            }
        }

        }
    }
