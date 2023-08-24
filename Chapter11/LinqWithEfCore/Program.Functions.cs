using LinqWithEfCore;
using LinqWithEfCore.Models;
using Microsoft.EntityFrameworkCore;

partial class Program
{
    static void FilterAndSort()
    {
        SectionTitle("Filter and sort");

        using (Northwind db = new Northwind())
        {

            //List<Product> filSortProducts = db.Products.Where(p=>p.UnitPrice < 10M).OrderByDescending(p=>p.unitPrice).ToList();
           DbSet<Product> allProducts = db.Products;


            IQueryable<Product> fillteredProducts = allProducts.Where(product => product.UnitPrice < 10M);

             IQueryable<Product> sortedAndFilteredProducts = fillteredProducts.OrderByDescending(product => product.UnitPrice);

            foreach (Product p in sortedAndFilteredProducts)
            {
               Console.WriteLine("{0}: {1} costs {2:$#,##0.00}",
                        p.ProductId, p.ProductName, p.UnitPrice);
            }


            WriteLine(sortedAndFilteredProducts.ToQueryString());
        }
    }

    static void filterAndSortQuery()
    {
        using(Northwind db = new Northwind())
        {
            IQueryable<Product> products =
                from product in db.Products
                where product.UnitPrice < 10M
                orderby product.UnitPrice descending
                select product;

            foreach (Product p in products)
            {
                Console.WriteLine("{0}: {1} costs {2:$#,##0.00}",
                         p.ProductId, p.ProductName, p.UnitPrice);
            }
            WriteLine(products.ToQueryString());

        }

    }
}