using Courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class CouresController : Controller
    {
        public ICourseRepository Repository { get; }
        public CouresController(ICourseRepository Repository) // DI 
        {
            this.Repository = Repository;
        }

        public IActionResult Index()
        {
            return View(Repository.GetAllCourses());
        }

        public IActionResult Info()
        {
            ViewBag.Author = "Srikanth Pragada";
            return View();
        }
    }
}
