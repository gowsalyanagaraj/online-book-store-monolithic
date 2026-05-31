namespace BookStore.Domain.Entities;

public class CartItem
{
    public Guid BookId { get; set; }
    public string BookTitle { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}