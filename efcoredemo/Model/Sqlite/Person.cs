using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  efcoredemo.Model.Sqlite
{
    public class Person
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
    }

    public class Student : Person
    {
        [MaxLength(10)]
        public string Course { get; set; }
    }

    public class Employee : Person
    {
        [MaxLength(10)]
        public string Job { get; set; }
    }
}
