using BookStore.Domain.Entities;

public class PaymentRepository : IPaymentRepository
{
    private readonly List<Payment> _payments = [];

    public List<Payment> GetAll()
    {
        return _payments;
    }

    public void Add(Payment payment)
    {
        _payments.Add(payment);
    }
}