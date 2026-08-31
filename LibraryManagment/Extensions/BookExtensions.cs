using LibraryManagment.Models;

namespace LibraryManagment.Extensions;

public static class BookExtensions
{
    public static void GetShortInfo(this Book book)
    {
        Console.WriteLine($"Title - {book.Title}");
        Console.WriteLine($"Author - {book.Author}");
        Console.WriteLine($"Price - {book.Price}AZN");
    }
    public static bool IsInStock(this Book book)
    {
        if (book.StockCount > 0)
            return true;

        return false;
    }
    public static void ApplyDiscount(this Book book, double percent)
    {
        if(percent < 0 || percent > 100)
        {
            throw new ArgumentException();
        }
        else
        {
            double discount = book.Price *(percent / 100);
        }
    }
}
