using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Db
{
    public class SeedDataBase
    {
        public static void Seed()
        {
            using(TodoContext db = new TodoContext())
            {
                db.Database.EnsureCreated();

                db.Shoppings.Add(new Shopping
                {
                    ShoppingItemID = new Guid(),
                    ShoppingItem = "Test"
                })
            }
        }
    }
}
