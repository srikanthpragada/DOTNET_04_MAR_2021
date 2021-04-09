using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class MoviesModel : PageModel
    {
        public string City { get; set; }
        public IActionResult OnGet()
        {
            // Get cookie with name city
            City = Request.Cookies["city"];
            if (City == null) // Cookie not found 
                return RedirectToPage("SaveCity");

            return Page();
        }
    }
}
