using efcoredemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model.Sqlite
{
    class ListBooks
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();

            foreach(var book in ctx.Books)
            {
                Console.WriteLine($"{book.Title} - {book.Author} - {book.Price}");
            }
        }
    }
}
