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
        if (book == null)
        {
            Console.WriteLine("Xəta: Əlavə edilən kitab boş (null) ola bilməz!");
            return;
        }
        if (books.Any(x => x.Title == book.Title && x.Author == book.Author))
        {
            throw new ArgumentException("Bu kitab artıq mövcuddur.");
        }
        books.Add(book);
        Console.WriteLine($"Id: {book.Id} Kitab elave edildi.");
    }

    public int CountByGenre(Genre genre)
    {
        var a = books.Count(x => x.Genre == genre);
        Console.WriteLine($"Bu janrda {a} kitab var.");
        return a;
    }

    public double GetAveragePrice()
    {
        var a = books.Average(x => x.Price);
        Console.WriteLine($"Orta qiymet: {a}");
        return a;
    }

    public List<Book>? GetByGenre(Genre genre)
    {
        var a = books.FindAll(x => x.Genre == genre);

        if (a.Count == 0)
        {
            throw new Exception("Bu janrda kitab tapılmadı.");
        }

        foreach (var book in a)
        {
            Console.WriteLine(book.Title);
        }

        return a;
    }

    public void GetById(int? id)
    {

        if (id is null)
        {
            throw new Exception("Id boş ola bilməz.");
        }
        var a = books.Find(x => x.Id == id);
        if (a is null)
        {
            throw new Exception("Bu id-li kitab tapılmadı.");
        }

        Console.WriteLine($"Title - {a.Title}");
        Console.WriteLine($"Author - {a.Author}");
        Console.WriteLine($"Price - {a.Price}");

    }

    public void GetByPriceRange(double min, double max)
    {
        bool founded = false;
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Price >= min && books[i].Price < max)
            {
                Console.WriteLine($"Title {books[i].Title}, Author {books[i].Author}, Price {books[i].Price}");
                founded = true;
            }
        }
        if (!founded)
        {
            throw new Exception("Bu qiymet aralığında kitab yoxdur.");
        }

    }


    public Book? GetCheapestBook()
    {
        return books.MinBy((x) => x.Price);
    }

    public Book? GetMostExpensiveBook()
    {
        var a = books.MaxBy((x) => x.Price);
        if (a is not null)
        {
            Console.WriteLine($"Book id : {a.Id} | Book Title : {a.Title} | Book Author : {a.Author} | Genre : {a.Genre} | Price : {a.Price} | Stock Count : {a.StockCount} | ");
            return a;
        }
        return null;
    }
}

