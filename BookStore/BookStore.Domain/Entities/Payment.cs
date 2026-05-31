using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities;

public class Payment
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public decimal Amount { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public DateTime PaidAt { get; set; }
}