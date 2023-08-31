using BookStore.Models.Domain;
using BookStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        private readonly IAuthorService _authorService;

        private readonly IGenreService _genreService;

        private readonly IPublisherService _publisherService;

        public BookController(IBookService service, IAuthorService authorService, IGenreService genreService, IPublisherService publisherService)
        {
            _bookService=service;
            _authorService=authorService;
            _genreService=genreService;
            _publisherService=publisherService;

        }

        public IActionResult Add()
        {
            var model = new Book();
            model.AuthorList=_authorService.GetAll().Select(a => new SelectListItem { Text= a.AuthorName, Value=a.Id.ToString() }).ToList();
            model.PublisherList=_publisherService.GetAll().Select(a => new SelectListItem { Text= a.PublisherName, Value=a.Id.ToString() }).ToList();
            model.GenreList=_genreService.GetAll().Select(a => new SelectListItem { Text= a.Name, Value=a.Id.ToString() }).ToList();
            return View(model);
        }


        [HttpPost]
        public IActionResult Add(Book model)
        {
            model.AuthorList=_authorService.GetAll().Select(a => new SelectListItem { Text= a.AuthorName, Value=a.Id.ToString(),Selected=a.Id==model.AuthorId }).ToList();
            model.PublisherList=_publisherService.GetAll().Select(a => new SelectListItem { Text= a.PublisherName, Value=a.Id.ToString(), Selected=a.Id==model.PublisherId }).ToList();
            model.GenreList=_genreService.GetAll().Select(a => new SelectListItem { Text= a.Name, Value=a.Id.ToString(), Selected=a.Id==model.GenreId }).ToList();


            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _bookService.Add(model);
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
            var model = _bookService.FindById(id);
            model.AuthorList=_authorService.GetAll().Select(a => new SelectListItem { Text= a.AuthorName, Value=a.Id.ToString(), Selected=a.Id==model.AuthorId }).ToList();
            model.PublisherList=_publisherService.GetAll().Select(a => new SelectListItem { Text= a.PublisherName, Value=a.Id.ToString(), Selected=a.Id==model.PublisherId }).ToList();
            model.GenreList=_genreService.GetAll().Select(a => new SelectListItem { Text= a.Name, Value=a.Id.ToString(), Selected=a.Id==model.GenreId }).ToList();
            return View(model);
        }


        [HttpPost]
        public IActionResult Update(Book model)
        {

            model.AuthorList=_authorService.GetAll().Select(a => new SelectListItem { Text= a.AuthorName, Value=a.Id.ToString(), Selected=a.Id==model.AuthorId }).ToList();
            model.PublisherList=_publisherService.GetAll().Select(a => new SelectListItem { Text= a.PublisherName, Value=a.Id.ToString(), Selected=a.Id==model.PublisherId }).ToList();
            model.GenreList=_genreService.GetAll().Select(a => new SelectListItem { Text= a.Name, Value=a.Id.ToString(), Selected=a.Id==model.GenreId }).ToList();

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _bookService.Update(model);
            if (result)
            {
                return RedirectToAction("GetAll");
            }
            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }


        public IActionResult Delete(int id)
        {

            var result = _bookService.Delete(id);
            return RedirectToAction("GetAll");
        }



        public IActionResult GetAll()
        {
            var data = _bookService.GetAll();
            return View(data);

        }
    }
}
