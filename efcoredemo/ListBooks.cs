using efcoredemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo
{
    class ListBooks
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();

            foreach(var book in ctx.Books)
            {
                Console.WriteLine($"{book.Title} - {book.Author} - {book.Price}");
                foreach(var c in book.Chapters)
                {
                    Console.WriteLine(c.Title);
                }
                Console.WriteLine("-----------------------");
            }
        }
    }
}
