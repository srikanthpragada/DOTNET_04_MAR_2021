using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages.Ajax
{
    public class DateTimeModel : PageModel
    {
        public IActionResult OnGet()
        {
            Thread.Sleep(5000); // Simulate delay
            return Content(DateTime.Now.ToString());
        }
    }
}
