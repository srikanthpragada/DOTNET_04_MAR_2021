using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Linq
{
    class QueryOperatorsDemo
    {
        static bool CostlyBook(Book book)
        {
            return book.Price > 500;
        }
        static void Main(string[] args)
        {
            var books = Book.GetBooks();

            // Costly books
            // var costly_books = books.Where(CostlyBook);
            var costly_books = books.Where(b => b.Price > 500);
            foreach (var b in costly_books)
                Console.WriteLine(b);
            
            // Display books with discounted price 
            var dis_books = books.Where(b => b.Price > 500)     // selection - filtering
                                 .Select(b => new { Title = b.Title, 
                                                    DiscountedPrice = b.Price * 0.80 });  // Projection

            foreach (var b in dis_books)
                Console.WriteLine($"{b.Title.PadRight(20)} - {b.DiscountedPrice}");
            

            // Take top 3 books by price 
            var sortedbooks = books.OrderByDescending(b => b.Price)
                                   .Take(3);
            foreach(var b in sortedbooks)
                Console.WriteLine(b);


            // Book with highest price 
            var maxprice = books.Max(b => b.Price);
            var book = books.Where(b => b.Price == maxprice).First();
            Console.WriteLine(book);

            // Sum of prices for books on ASP.NET
            Console.WriteLine(books.Where(b => b.Title.Contains("ASP.NET"))
                                   .Sum(b => b.Price));
        }
    }
}
