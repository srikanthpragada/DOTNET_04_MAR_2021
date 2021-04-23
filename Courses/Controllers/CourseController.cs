using Courses.Models;
using Courses.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        public ICourseRepository Repository { get; }
        public CourseController(ICourseRepository Repository) // DI 
        {
            this.Repository = Repository;
        }

        public IActionResult Index()
        {
            return View(Repository.GetAllCourses());
        }

        public IActionResult Info()
        {
            var courses = Repository.GetAllCourses();

            ViewBag.Author = "Srikanth Pragada";
            ViewBag.Count = courses.Count();
            ViewBag.AvgFee = courses.Average(c => c.Fee);
            return View();
        }

        public IActionResult About()
        {
            var courses = Repository.GetAllCourses();
            var viewModel = new AboutViewModel
            {
                Author = "Srikanth Pragada",
                Count = courses.Count(),
                AvgFee = (int)courses.Average(c => c.Fee)
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new Course();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Course course)
        {
            Repository.AddCourse(course);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Repository.DeleteCourse(id);
            return RedirectToAction("Index");
        }
    }
}
