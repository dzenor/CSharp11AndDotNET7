using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Packt.Shared;
using Northwind.Mvc.Models;
using Northwind.MVC.Models;

namespace Northwind.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _context;

        public HomeController(ILogger<HomeController> logger, NorthwindContext injectedContext)
        {
            _logger = logger;
            _context = injectedContext;
        }

        public IActionResult Index()
        {

            HomeIndexViewModel model = new(
                VisitorCount: Random.Shared.Next(1, 100),
                Categories: _context.Categories.ToList(),
                Products: _context.Products.ToList()
                );

            return View(model);

        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult ProductDetail(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest("You must pass a product ID in the route, forexample, /Home/ProductDetail/21");
}
            Product? product = _context.Products.SingleOrDefault(p => p.ProductId == id);

            


            if (product is null)
            {
                return NotFound($"ProductId {id} not found.");
            }
            return View(product); // pass model to view and then return result
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}