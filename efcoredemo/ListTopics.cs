using efcoredemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo
{
    class ListTopics
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogContext();

            // Eager loading 
            foreach (var t in ctx.Topics.Include( t => t.Course))
                Console.WriteLine($"{t.Course.Title} - {t.Title}");
        }
    }
}
