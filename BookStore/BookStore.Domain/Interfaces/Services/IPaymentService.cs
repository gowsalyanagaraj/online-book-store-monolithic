using BookStore.Domain.Entities;
using BookStore.Domain.Enums;

namespace BookStore.Domain.Interfaces
{
    public interface IPaymentService
    {
        Payment ProcessPayment(Guid orderId, decimal amount);
        List<Payment> GetPayments();
        bool IsPaymentStatusPaid(Guid orderId);
    }
}
