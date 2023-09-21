using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.Data;
using Ogani.Data.Entities;
using Ogani.Models;
using System.Diagnostics;

namespace Ogani.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _dbContext;


		public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
		{
			_logger = logger;
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			List<Category> categories = _dbContext.Categories.ToList();
            List<Product> products = _dbContext.Products.Include(p => p.ProductCategory).ToList();
			ShopViewModel model = new ShopViewModel (categories, products);
            return View(model);
		}

		public IActionResult Shop()
		{
            List<Category> categories = _dbContext.Categories.ToList();
			List<Product> products = _dbContext.Products.Include(p => p.ProductCategory).ToList();
            return View(categories);
        }
		public IActionResult Blog()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult ProductDetails(int id)
		{
			return View();
		}

        public IActionResult BlogDetails(int id)
        {
            return View();
        }
        public IActionResult ShoppingBag()
        {
            return View();
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}