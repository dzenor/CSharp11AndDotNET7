namespace E_BookStoreUi
{
    public interface ICartRepository
    {
      Task<int> AddItem(int bookId, int quantity);
        Task<int> RemoveItem(int bookId);

        Task<ShoppingCard> GetUserCart();

        Task<int> GetCartItemCount(string userId = "");
    }
}