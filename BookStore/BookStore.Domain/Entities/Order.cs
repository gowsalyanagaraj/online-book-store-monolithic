using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public List<CartItem> Items { get; set; } = [];
    public decimal TotalAmount { get; set; }
    public DateTime CreatedAt { get; set; }
}