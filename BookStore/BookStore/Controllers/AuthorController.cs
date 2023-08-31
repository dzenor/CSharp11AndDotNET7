using BookStore.Models.Domain;
using BookStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
 
        public class AuthorController : Controller
        {
            private readonly IAuthorService _authorService;
            public AuthorController(IAuthorService service)
            {
                _authorService=service;
            }

            public IActionResult Add()
            {
                return View();
            }


            [HttpPost]
            public IActionResult Add(Author model)
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var result = _authorService.Add(model);
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
                var record = _authorService.FindById(id);
                return View(record);
            }


            [HttpPost]
            public IActionResult Update(Author model)
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var result = _authorService.Update(model);
                if (result)
                {
                    return RedirectToAction("GetAll");
                }
                TempData["msg"] = "Error has occured on server side";
                return View(model);
            }


            public IActionResult Delete(int id)
            {

                var result = _authorService.Delete(id);
                return RedirectToAction("GetAll");
            }



            public IActionResult GetAll()
            {
                var data = _authorService.GetAll();
                return View(data);

            }


        }
    }

