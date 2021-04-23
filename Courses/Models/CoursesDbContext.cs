using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class CoursesDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public string ConnectionString { get; }

        public CoursesDbContext(IConfiguration Configuration)
        {
            ConnectionString = Configuration.GetConnectionString("CoursesConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
        }
    }
}
