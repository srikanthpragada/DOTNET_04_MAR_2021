using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    class TrainingContext : DbContext
    {
        public DbSet<Course> Courses
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data source=(localdb)\mssqllocaldb;Initial Catalog=training;Integrated Security=True");
    }
}
