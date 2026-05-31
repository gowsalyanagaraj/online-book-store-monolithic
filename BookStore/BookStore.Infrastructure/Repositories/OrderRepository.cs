using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;

namespace BookStore.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = [];

    public List<Order> GetAll()
    {
        return _orders;
    }

    public void Add(Order order)
    {
        _orders.Add(order);
    }
}