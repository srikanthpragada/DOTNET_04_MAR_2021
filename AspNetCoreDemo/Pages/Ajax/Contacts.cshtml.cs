using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore.Pages.Ajax
{
    public class ContactsModel : PageModel
    {
        public JsonResult OnGet()
        {
            var contacts = new[] { new { Name = "Abc", Email = "abc@gmail.com" }, 
                                   new { Name = "Pqr", Email = "pqr@gmail.com" } };
            return new JsonResult(contacts);
        }
    }
}
