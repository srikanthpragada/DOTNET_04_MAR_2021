using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    // Domain class or Entity class 
    public class Course
    {
        public int Id
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }
        public string Prereq
        {
            get; set;
        }
        public int Fee { get; set; }
    }
}
