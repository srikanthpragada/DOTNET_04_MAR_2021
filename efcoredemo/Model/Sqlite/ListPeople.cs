using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model.Sqlite
{
    class ListPeople
    {
        static void Main(string[] args)
        {

            var ctx = new CatalogContext();
            
            foreach (var s in ctx.Students)
            {
                Console.WriteLine($"{s.Name} - {s.Course}");
            }

            foreach (var e in ctx.Employees)
            {
                Console.WriteLine($"{e.Name} - {e.Job}");
            }

            foreach (var p in ctx.People)
            {
                Console.WriteLine(p.GetType().Name);
                Console.WriteLine($"{p.Name} - {p.Email} ");
            }

        }
    }
}
