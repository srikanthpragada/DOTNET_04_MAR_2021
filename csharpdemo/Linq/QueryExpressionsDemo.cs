using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Linq
{
    class QueryExpressionsDemo
    {
        static void Main(string[] args)
        {
            var books = Book.GetBooks();

            // Get Costly books
            var costlyTitles = from b in books
                               where b.Price > 500
                               select b.Title;

            foreach (var title in costlyTitles)
                Console.WriteLine(title);


            // All books with 20% discount and desc order of price 
            var disbooks = from b in books
                           orderby b.Price descending
                           select new { Title = b.Title, Price = b.Price * .80 };

            //books.OrderByDescending(b => b.Price)
            //     .Select(b => new { Title = b.Title, Price = b.Price * 0.80 });

            foreach (var b in disbooks)
                Console.WriteLine(b);

             
            // Display book with max price 
            var maxprice = books.Max(b => b.Price);
            var costlybook = (from b in books
                              where b.Price == maxprice
                              select b).First();

            
            var bigtitles = from b in books
                            where b.Title.Length > 10
                            orderby b.Price
                            select b.Title;

            foreach(var title in bigtitles)
                Console.WriteLine(title);
        }
    }
}
