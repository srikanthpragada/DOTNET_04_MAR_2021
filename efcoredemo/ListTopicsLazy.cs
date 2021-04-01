using efcoredemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo
{
    class ListTopicsLazy
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();

            // Lazy loading 
            foreach (var t in ctx.Topics)
            {
                // Console.WriteLine(t.GetType().FullName);
                Console.WriteLine($"{t.Course.Title} - {t.Title}");
            }
        }
    }
}
