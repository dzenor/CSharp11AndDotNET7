using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_BookStoreUi.Controllers
{
    [Authorize]
    public class CartContorller : Controller

    {
        private readonly ICartRepository _cartRepo;

        public CartContorller(ICartRepository cartRepo)
        {
       
           _cartRepo=cartRepo;
        }

        public async Task<IActionResult> AddItem(int bookId,int quantity=1,int redirect=0)
        {

            var cartCount = await _cartRepo.AddItem(bookId, quantity);

            if(redirect == 0)   
                return Ok(cartCount);
                return RedirectToAction("GetUserCart");
            
        }

        public async Task<IActionResult> RemoveItem(int bookId)
        {
            var cartCount = await _cartRepo.RemoveItem(bookId);
            return RedirectToAction("GetUserCart");

           
        }

        public async Task<IActionResult>GetUserCart()
        {
            var cart = await _cartRepo.GetUserCart();

            return View(cart);
        }

        public async Task<IActionResult> GetTotalItemInCart()
        {
            int cartItem = await _cartRepo.GetCartItemCount();
            return Ok(cartItem);
        }



    }
}
