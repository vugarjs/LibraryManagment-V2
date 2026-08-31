using LibraryManagment.Enums;
using LibraryManagment.Interfaces;
using LibraryManagment.Models;

namespace LibraryManagment.Services;

public class BookService : IBookService
{
    static List<Book> books = new List<Book>();
    public BookService()
    {
        books = new List<Book>();
    }
    public void Add(Book book)
    {
        if(book == null)
        {
            Console.WriteLine("Xəta: Əlavə edilən kitab boş (null) ola bilməz!");
            return;
        }
        if (!books.Contains(book))
        {
            books.Add(book);
            Console.WriteLine("Kitab elave edildi.");
        }
            
    }

    public int CountByGenre(Genre genre)
    {
       return books.Count(x => x.Genre == genre);
    }

    public double GetAveragePrice()
    {
        return books.Average(x => x.Price);
    }

    public List<Book>? GetByGenre(Genre genre)
    {
        return books.FindAll(x => x.Genre == genre);
    }

    public void GetById(int id)
    {
        var a = books.Find(x => x.Id == id);
        Console.WriteLine($"Title - {a.Title}");
        Console.WriteLine($"Author - {a.Author}");
        Console.WriteLine($"Price - {a.Price}");
    }

    public void GetByPriceRange(double min, double max)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Price >= min && books[i].Price < max)
            {
                Console.WriteLine($"Title {books[i].Title}");
                Console.WriteLine($"Price {books[i].Price}");
            }
        }
    }


    public Book? GetCheapestBook()
    {
        return books.MinBy((x) => x.Price);
    }

    public Book? GetMostExpensiveBook()
    {
        return books.MaxBy((x) => x.Price);
    }
}
