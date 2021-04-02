using Microsoft.EntityFrameworkCore;

namespace efcoredemo.Model.Sqlite
{
    class CatalogContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=d:\classroom\mar4\catalog.db");
        }
    }
}
