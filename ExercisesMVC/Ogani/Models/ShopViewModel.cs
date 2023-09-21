using Microsoft.EntityFrameworkCore;
using Ogani.Data.Entities;

namespace Ogani.Models
{
    public class ShopViewModel
    {
        public ShopViewModel(List<Category> categories, List<Product> allProducts)
        {
            Categories=categories;
            AllProducts=allProducts;
            FeaturedProducts=new List<Product>();
            TopProducts=new List<Product>(); 
        }

         public ShopViewModel(List<Category> categories, List<Product> allProducts, List<Product> featuredProducts, List<Product> topProducts)
        {
            Categories=categories;
            AllProducts=allProducts;
            FeaturedProducts=featuredProducts;
            TopProducts=topProducts;
        }

        public List<Category> Categories { get; private set; }
       public List<Product> AllProducts { get; private set; }
       public List<Product> FeaturedProducts { get; private set; }
       public List<Product> TopProducts { get; private set; }
    }
}
