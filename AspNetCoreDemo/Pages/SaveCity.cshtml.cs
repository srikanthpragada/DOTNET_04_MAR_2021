using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class SaveCityModel : PageModel
    {

        public IActionResult OnGet(String City)
        {
            if (City == null)
               return Page();

            // Store city as cookie
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Append("city",City, options);
            return RedirectToPage("Movies");
       }
    }
}
