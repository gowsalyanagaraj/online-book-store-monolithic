using BookStore.Domain.Entities;

namespace BookStore.Domain.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(Guid userId, List<CartItem> items);
        List<Order> GetOrders();
    }
}
