using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }  // Navigation Property 
    }
}
