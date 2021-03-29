using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.Linq
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qoh { get; set; }
    }

    class TestProduct
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Name = "Product1",Price = 3000, Qoh = 10},
                new Product { Name = "Product2",Price = 5000, Qoh = 1},
                new Product { Name = "Product3",Price = 15000, Qoh = 6},
                new Product { Name = "Product4",Price = 11000, Qoh = 8},
                new Product { Name = "Product5",Price = 1000, Qoh = 12}
            };

            var cheapProducts = from p in products
                                where p.Price < 5000
                                select p;

            foreach(var p in cheapProducts)
                Console.WriteLine(p.Name);

            var avgprice = products.Average(p => p.Price);

            //foreach(var p in products)
            //    if ( p.Price > avgprice)
            //        Console.WriteLine(p.Name);

            var costlyProducts = from p in products
                                 where p.Price > avgprice
                                 select p.Name;

            foreach(var n in costlyProducts)
                Console.WriteLine(n);






        }
    }
}
