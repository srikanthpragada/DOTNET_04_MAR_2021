using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;

namespace AspNetCoreDemo.Pages
{
    public class ListPhotosModel : PageModel
    {
        public ListPhotosModel(IWebHostEnvironment WebHost)
        {
            this.WebHost = WebHost;
        }

        public IWebHostEnvironment WebHost { get; }

        public List<IFileInfo> Files { get; set; }

        public void OnGet()
        {
            // Get all files from photos folder in wwwroot 
            var files = WebHost.WebRootFileProvider
                               .GetDirectoryContents("photos");
            Files = files.ToList();
        }
    }
}
