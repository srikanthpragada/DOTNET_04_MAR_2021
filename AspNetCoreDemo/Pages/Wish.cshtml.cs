using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{
    public class WishModel : PageModel
    {
        public string Message { get; set; }
        public void OnPost(string user)
        {
            var hours = DateTime.Now.Hour;
            if (hours < 12)
                Message = $"Good Morning {user}";
            else
                if (hours < 17)
                   Message = $"Good Afternoon {user}";
                else
                   Message = $"Good Evening {user}";
        }
    }
}
