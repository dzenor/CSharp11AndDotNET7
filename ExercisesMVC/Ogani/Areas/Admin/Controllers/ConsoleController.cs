using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.Data;
using Ogani.Data.Entities;

namespace Ogani.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ConsoleController : Controller
    {

        private readonly ApplicationDbContext _db;
        public ConsoleController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task< IActionResult> Products()
        {
            List<Product> products = await _db.Products.ToListAsync();

            return View(products);
        }

        public async Task<IActionResult> Categories()
        {
            List<Category> categories = await _db.Categories.ToListAsync();

            return View(categories);
        }


    }
}
