using BookStore.Models.Domain;
using BookStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherService _publisherService;
        public PublisherController(IPublisherService service)
        {
            _publisherService=service;
        }

        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Publisher model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _publisherService.Add(model);
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
            var record = _publisherService.FindById(id);
            return View(record);
        }


        [HttpPost]
        public IActionResult Update(Publisher model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _publisherService.Update(model);
            if (result)
            {
                return RedirectToAction("GetAll");
            }
            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }


        public IActionResult Delete(int id)
        {

            var result = _publisherService.Delete(id);
            return RedirectToAction("GetAll");
        }



        public IActionResult GetAll()
        {
            var data = _publisherService.GetAll();
            return View(data);

        }
    }
}
