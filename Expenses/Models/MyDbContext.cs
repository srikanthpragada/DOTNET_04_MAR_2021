using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Expenses.Models
{
    public class MyDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Expenditure> Expenses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=expenses;Integrated Security=True");
        }
    }
}
