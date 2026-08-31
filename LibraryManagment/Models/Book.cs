using LibraryManagment.Enums;

namespace LibraryManagment.Models;

public class Book
{
    public Book(string title, string author, int pageCount, int price, int stockCount ,Genre genre)
    {
        idcount++;
        Id = idcount;
        Title = title;
        Author = author;
        PageCount = pageCount;
        Price = price;
        StockCount = stockCount;
        Genre = genre;
        Created = DateTime.Now;
    }
    public int Id { get; set; }
    private static int idcount {  get; set; }
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public int PageCount { get; set; }
    public double Price { get; set; }
    public int StockCount { get; set; }
    public Genre Genre { get; set; }
    public DateTime Created { get; set; }

}
