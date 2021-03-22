using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Linq
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Author} - {Price}";
        }
        public static Book[] GetBooks()
        {
            return new Book[] {
                new Book { Title="C# 9.0", Author="Anders", Price = 550},
                new Book { Title="Oracle 18c",Author="Jason Price", Price=650},
                new Book { Title="ASP.NET Core", Author ="Walther", Price = 799},
                new Book { Title="jQuery In Action", Author ="Craig Walls", Price = 500},
                new Book { Title="ASP.NET Core and Blazor", Author="Dino",Price = 500}
            };
        } // end of Book class
    }
}
