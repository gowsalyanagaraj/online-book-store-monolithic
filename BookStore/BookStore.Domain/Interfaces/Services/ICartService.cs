using BookStore.Domain.Entities;

namespace BookStore.Domain.Interfaces
{
    public interface ICartService
    {
        List<CartItem> GetItems();
        void Add(Book book);
        void RemoveItem(Guid bookId);
        void IncreaseQuantity(Guid bookId);
        void Clear();
    }
}
