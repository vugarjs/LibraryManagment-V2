using LibraryManagment.Enums;
using LibraryManagment.Models;
using LibraryManagment.Services;

namespace LibraryManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();
            Genre genre = new Genre();
            Book book = new Book("C#", "Vuqar", 100, 100, 2, genre);
            bookService.Add(book);


            //bookService.GetById(1);
            bookService.GetByGenre(genre);

        }
    }
}
