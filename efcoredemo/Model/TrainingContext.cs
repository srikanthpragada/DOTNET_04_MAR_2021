using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    class CatalogContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // options.LogTo(Console.WriteLine, LogLevel.Information);
            options.UseLazyLoadingProxies();  // For Lazy loading 
            options.UseSqlServer(@"Data source=(localdb)\mssqllocaldb;Initial Catalog=training;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}
