using BookStore.Models.Domain;
using BookStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class GenreController : Controller
    {
       private readonly IGenreService _genreService;
        public GenreController(IGenreService service)
        {
            _genreService=service;        }

        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _genreService.Add(model);
               if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }


        public IActionResult Update(int id)
        {
            var record = _genreService.FindById(id);
            return View();
        }


        [HttpPost]
        public IActionResult Update(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _genreService.Update(model);
            if (result)
            {
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction("GetAll");
            }
            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }

   


        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _genreService.Delete(id);
            return RedirectToAction("GetAll");
           
        }


        public IActionResult GetAll()
        {
            var data = _genreService.GetAll();
            return View(data);

        }


    }
}
