using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;


namespace Northwind.web.Pages
{
    public class SuppliersModel : PageModel
    {
        private NorthwindContext db;

        public SuppliersModel (NorthwindContext injectedContext)
        {
            db = injectedContext;
        }
        public IEnumerable<Supplier>? Suppliers { get; set; }

        [BindProperty]
        public Supplier? Supplier { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Suppliers";

            Suppliers = db.Suppliers.OrderBy(s => s.Country).ThenBy(s => s.SupplierName);

            
        }


        public IActionResult OnPost()
        {
            if((Supplier is not null) && ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/Suppliers");
            }
            else
            {
                return Page();
            }
        }
    }
}
