using BookStore.Domain.Entities;

public interface IPaymentRepository
{
    List<Payment> GetAll();
    void Add(Payment payment);
}