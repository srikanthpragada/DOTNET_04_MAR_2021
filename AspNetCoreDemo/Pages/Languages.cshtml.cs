using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class LanguagesModel : PageModel
    {
        public string Languages { get; set; }
        public void OnGet(String name)
        {
            Languages = HttpContext.Session.GetString("languages");
            if (name != null)
            {
                if (Languages != null)
                    Languages += "," + name;
                else
                    Languages = name;

                HttpContext.Session.SetString("languages", Languages);
            }

           
        }
    }
}
