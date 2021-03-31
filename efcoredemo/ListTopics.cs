using efcoredemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo
{
    class ListTopics
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();

            foreach (var t in ctx.Topics.Include("Course"))
                Console.WriteLine($"{t.Course.Title} - {t.Title}");
        }
    }
}
