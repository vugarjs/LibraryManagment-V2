using LibraryManagment.Enums;
using LibraryManagment.Models;

namespace LibraryManagment.Interfaces;

public interface IBookService
{
    void Add(Book book);
    void GetById(int? id);
    List<Book>? GetByGenre(Genre genre);
    Book? GetMostExpensiveBook();
    Book? GetCheapestBook();
    double GetAveragePrice();
    int CountByGenre(Genre genre);
    void GetByPriceRange(double min, double max);
}
