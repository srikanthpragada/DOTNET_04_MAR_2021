using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Expenses.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Expenditure> Expenses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=expenses;Integrated Security=True");
        }
    }
}
