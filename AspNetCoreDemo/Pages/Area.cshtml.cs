using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class AreaModel : PageModel
    {
        [BindProperty]
        public int Length { get; set; }

        [BindProperty]
        public int Width { get; set; }

        public int Area { get; set; }
        public void OnPost()
        {
            Area = Length * Width; 
        }
    }
}
