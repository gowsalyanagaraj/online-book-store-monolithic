using BookStore.Domain.Entities;

namespace BookStore.Domain.Interfaces
{
    public interface IBookService
    {
        List<Book> GetBooks();
        void AddBook(Book book);

    }
}
