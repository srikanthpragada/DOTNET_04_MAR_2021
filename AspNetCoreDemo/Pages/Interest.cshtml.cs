using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class InterestModel : PageModel
    {
        [BindProperty]
        [Range(10000,1000000, ErrorMessage ="Invalid Amount!")]
        [Required(ErrorMessage ="Amount must be given!")]
        public int Amount { get; set; }
        [BindProperty]
        [Range(30, 3600, ErrorMessage = "Invalid Period!")]
        [Required(ErrorMessage = "Period in days must be given!")]
        public int Period { get; set; }
        public int Interest { get; set; }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Period < 100)
                    Interest = Amount * 5 / 100;
                else
                    if (Period < 200)
                    Interest = Amount * 6 / 100;
                else
                    Interest = Amount * 7 / 100;
            }
        }
    }
}
