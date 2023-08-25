using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.Data;
using Ogani.Data.Entities;

namespace Ogani.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class Console : Controller
    {

        private readonly ApplicationDbContext _db;
        public Console(ApplicationDbContext dbContext)
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
    }
}
