using BookStore.Domain.Entities;

namespace BookStore.Domain.Interfaces;

public interface IOrderRepository
{
    List<Order> GetAll();
    void Add(Order order);
}