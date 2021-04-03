using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace efcoredemo.Model.Sqlite
{
    class CatalogContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.LogTo(Console.WriteLine, LogLevel.Information);
            options.UseSqlite(@"Data Source=d:\classroom\mar4\catalog.db");
        }
    }
}
