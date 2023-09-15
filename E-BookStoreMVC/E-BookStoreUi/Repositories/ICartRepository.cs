namespace E_BookStoreUi
{
    public interface ICartRepository
    {
        Task<bool> AddItem(int bookId, int quantity);
        Task<bool> RemoveItem(int bookId);

        Task<IEnumerable<ShoppingCard>> GetUserCart();
    }
}