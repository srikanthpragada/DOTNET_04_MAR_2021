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
        public void OnGet(String lang)
        {
            Languages = HttpContext.Session.GetString("languages");
            if (lang != null)
            {
                if (Languages != null)
                    Languages += "," + lang;  // Append to existing langs
                else
                    Languages = lang;   // First lang

                HttpContext.Session.SetString("languages", Languages);
            }
        }
    }
}
