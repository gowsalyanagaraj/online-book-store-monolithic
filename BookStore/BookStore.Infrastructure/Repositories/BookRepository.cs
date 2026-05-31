using BookStore.Domain.Entities;
using BookStore.Domain.Interfaces;

namespace BookStore.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _books =
    [
        new()
        {
            Id = Guid.NewGuid(),
            Title = "The Silent Patient",
            Author = "Alex Michaelides",
            Price = 500,
            Stock = 20
        },
        new()
        {
            Id = Guid.NewGuid(),
            Title = "The Housemaid",
            Author = "Freida McFadden",
            Price = 700,
            Stock = 10
        },
        new()
        {
            Id = Guid.NewGuid(),
            Title = "The Thursday Murder Club",
            Author = "Richard Osman",
            Price = 600,
            Stock = 15
        },
        new()
        {
            Id = Guid.NewGuid(),
            Title = "Twisted Love",
            Author = "Ana Huang",
            Price = 400,
            Stock = 10
        },
        new()
        {
            Id = Guid.NewGuid(),
            Title = "Can We Be Strangers Again?",
            Author = "Shrijeet Shandilya",
            Price = 200,
            Stock = 30
        }
    ];

    public List<Book> GetAll()
    {
        return _books;
    }

    public Book? GetById(Guid id)
    {
        return _books.FirstOrDefault(x => x.Id == id);
    }

    public void Add(Book book)
    {
        _books.Add(book);
    }
}