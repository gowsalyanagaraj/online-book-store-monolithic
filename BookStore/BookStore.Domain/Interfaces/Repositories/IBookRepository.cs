using BookStore.Domain.Entities;

namespace BookStore.Domain.Interfaces;

public interface IBookRepository
{
    List<Book> GetAll();
    Book? GetById(Guid id);
    void Add(Book book);
}