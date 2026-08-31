using LibraryManagment.Enums;
using LibraryManagment.Extensions;
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
            var genre1 = Genre.Other;
            Book book1 = new Book("C#", "Vuqar", 100, 200, 2, genre);// id 1
            Book book2 = new Book("Python", "Eli", 100, 300, 2, genre1);// id 2
            Book book3 = new Book("C++", "Senan", 100, 200, 2, genre);// id 3
            Book book4 = new Book("C", "Musa", 100, 500, 2, genre);// id 4
            Book book5 = new Book("Java", "Eli", 100, 600, 2, genre);// id 5
            Book book6 = new Book("JavaScript", "Eli", 100, 700, 2, genre);// id 6

            try
            {
                bookService.Add(book1);
                bookService.Add(book2);
                bookService.Add(book3);
                bookService.Add(book4);
                bookService.Add(book5);
                bookService.Add(book6);

                //BookExtensions.ApplyDiscount(book1, 20);
                //bookService.GetById(21);
                //bookService.GetMostExpensiveBook();
                // bookService.GetAveragePrice();
                bookService.GetByGenre(genre);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //bookService.GetById(1);

        }
    }
}
