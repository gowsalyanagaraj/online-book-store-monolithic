using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;

public class BookService : IBookService
{
    private readonly IBookRepository _repository;

    public BookService(IBookRepository repository)
    {
        _repository = repository;
    }

    public List<Book> GetBooks()
    {
        return _repository.GetAll();
    }

    public void AddBook(Book book)
    {
        _repository.Add(book);
    }
}