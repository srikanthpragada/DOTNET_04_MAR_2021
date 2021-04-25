using Courses.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:6420");
            try
            {
                var result = client.GetStringAsync("/api/Courses");
                var courses = JsonConvert.DeserializeObject<List<Course>>(result.Result);
                return View(courses);
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Sorry! Could not get details!";
            }

            return View(null);
        }
    }
}
