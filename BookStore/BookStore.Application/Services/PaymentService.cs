using BookStore.Domain.Entities;
using BookStore.Domain.Enums;
using BookStore.Domain.Interfaces;

public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _repo;

    public PaymentService(IPaymentRepository repo)
    {
        _repo = repo;
    }

    public Payment ProcessPayment(Guid orderId, decimal amount)
    {
        var payment = new Payment
        {
            Id = Guid.NewGuid(),
            OrderId = orderId,
            Amount = amount,
            Status = PaymentStatus.Success,
            PaidAt = DateTime.Now
        };

        //throw new Exception("Payment failed");

        _repo.Add(payment);

        return payment;
    }

    public List<Payment> GetPayments()
    {
        return _repo.GetAll();
    }

    public bool IsPaymentStatusPaid(Guid orderId)
    {
        List<Payment> payments = _repo.GetAll();

        if(payments == null || payments.Count == 0 || !payments.Any(x => x.OrderId == orderId)) return false;

        Payment payment = payments.FirstOrDefault(x => x.OrderId == orderId);

        return payment.Status == PaymentStatus.Success;
    }
}