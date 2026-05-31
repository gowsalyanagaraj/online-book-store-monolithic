using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;

public class CartService : ICartService
{
    private readonly List<CartItem> _items = [];

    public List<CartItem> GetItems()
    {
        return _items;
    }

    public void Add(Book book)
    {
        var item = _items.FirstOrDefault(x => x.BookId == book.Id);

        if (item == null)
        {
            _items.Add(new CartItem
            {
                BookId = book.Id,
                BookTitle = book.Title,
                Price = book.Price,
                Quantity = 1
            });
        }
        else
        {
            item.Quantity++;
        }
    }

    public void RemoveItem(Guid bookId)
    {
        var item = _items.FirstOrDefault(x => x.BookId == bookId);
        if (item != null)
        {
            if(item.Quantity > 1)
            {
                item.Quantity--;
            }
            else
            {
                _items.Remove(item);
            }
        }
    }

    public void IncreaseQuantity(Guid bookId)
    {
        var item = _items.FirstOrDefault(x => x.BookId == bookId);
        if (item != null)
        {
            item.Quantity++;
        }
    }

    public void Clear()
    {
        _items.Clear();
    }
}