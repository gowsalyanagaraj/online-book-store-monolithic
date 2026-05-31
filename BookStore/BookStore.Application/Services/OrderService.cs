using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _repo;

    public OrderService(IOrderRepository repo)
    {
        _repo = repo;
    }

    public Order CreateOrder(Guid userId, List<CartItem> items)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            Items = items.ToList(),
            CreatedAt = DateTime.Now,
            TotalAmount = items.Sum(x => x.Price * x.Quantity)
        };

        _repo.Add(order);

        return order;
    }

    public List<Order> GetOrders()
    {
        return _repo.GetAll();
    }
}