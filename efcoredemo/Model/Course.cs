using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    // Domain class or Entity class 
    class Course
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
    }
}
