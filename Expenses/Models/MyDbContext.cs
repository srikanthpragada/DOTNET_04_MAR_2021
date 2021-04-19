using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Expenses.Models
{
    public class MyDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Expenditure> Expenses { get; set; }
        public string ConnectionString { get; }

        public MyDbContext(IConfiguration Configuration)
        {
            ConnectionString = Configuration.GetConnectionString("ExpensesConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
        }
    }
}
