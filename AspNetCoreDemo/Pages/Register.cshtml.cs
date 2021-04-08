using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Invalid length for username. It must be between {2} and {1}")]
        [Required]
        public string Username { get; set; }

        [BindProperty]
        [StringLength(20,MinimumLength = 6, ErrorMessage = "Invalid length for password. It must be between {2} and {1}")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Invalid length for password. It must be between {2} and {1}")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }



        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Process 
                return RedirectToPage("Login");
            }

            return Page(); // Redisplay same page 
        }
    }
}
