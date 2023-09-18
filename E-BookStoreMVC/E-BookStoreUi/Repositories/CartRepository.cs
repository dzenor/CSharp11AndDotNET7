using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_BookStoreUi.Repositories 
{


    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartRepository(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext=dbContext;
            _userManager=userManager;
            _httpContextAccessor=httpContextAccessor;
        }

        public async Task<bool> AddItem(int bookId, int quantity)
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                string userId = GetUserId();
                if (string.IsNullOrEmpty(userId))
                {
                    return false;
                }

                var cart = await GetCart(userId);
                if (cart == null)
                {
                    cart = new ShoppingCard
                    {
                        UserId = userId
                    };
                    _dbContext.ShoppingCards.Add(cart);
                }
                _dbContext.SaveChanges();
                //cart detail section

                var cartItem = _dbContext.CardDetails.FirstOrDefault(a => a.ShoppingCardId == cart.Id && a.BookId == bookId);
                if (cartItem is not null)
                {
                    cartItem.Quantity += quantity;
                }
                else
                {
                    cartItem = new CardDetail
                    {
                        BookId = bookId,
                        ShoppingCardId = cart.Id,
                        Quantity = quantity
                    };
                    _dbContext.CardDetails.Add(cartItem);
                }
                _dbContext.SaveChanges();
                transaction.Commit();
                return true;


            } catch (Exception ex)
            {
                return false;
            }


        }

        public async Task<bool> RemoveItem(int bookId)
        {
            //using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                string userId = GetUserId();
                if (string.IsNullOrEmpty(userId))
                {
                    return false;
                }

                var cart = await GetCart(userId);
                if (cart == null)
                {
                    return false;
                }
                _dbContext.SaveChanges();
                //cart detail section

                var cartItem = _dbContext.CardDetails.FirstOrDefault(a => a.ShoppingCardId == cart.Id && a.BookId == bookId);
                if (cartItem is null)
                {
                    return false;
                }
                else if (cartItem.Quantity == 1)
                {
                    _dbContext.CardDetails.Remove(cartItem);
                }


                else
                {
                    cartItem.Quantity = cartItem.Quantity - 1;
                }
                _dbContext.SaveChanges();
                //transaction.Commit();
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public async Task<IEnumerable<ShoppingCard>> GetUserCart()
        {
            var userId = GetUserId();
            if(userId == null)
            {
                throw new Exception("Invalid user");
            }
            var shoppingCart =await _dbContext.ShoppingCards
                .Include(a => a.CartDetails)
                .ThenInclude(a => a.Book)
                .ThenInclude(a => a.Genre)
                .Where(a => a.UserId == userId).ToListAsync();

            return shoppingCart;
        }
            

        private async Task<ShoppingCard> GetCart(string userId)
        {
            var cart = await _dbContext.ShoppingCards.FirstOrDefaultAsync(x => x.UserId == userId);
            return cart;


        }

        private async Task<int> GetCartItemCount(string userId"")
        {
            if (!string.IsNullOrEmpty(userId))
            {
                userId = GetUserId();
            }

            var data = (from cart in _dbContext.ShoppingCards
                        join cardDetail in _dbContext.CardDetails
                        on cart.Id equals cardDetail.ShoppingCardId
                        select new { cardDetail.Id }

                        ).ToList().Count();
                            
        }


        private string GetUserId()
        {
            var principal = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(principal);
            return userId;
        }
    }
}
