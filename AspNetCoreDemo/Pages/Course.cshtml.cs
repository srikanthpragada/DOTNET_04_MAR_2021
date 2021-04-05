using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class CourseModel : PageModel
    {
        public string Title { get; set; }
        public int Fee { get; set; }
        public List<String> Topics { get; set; }

        public void OnGet()
        {
            Title = "ASP.NET Core";
            Fee = 10000;
            Topics = new List<string>() { "Entity Framework Core", "ASP.NET Core", "ASP.NET Core MVC", "Web API" };
        }
    }
}
