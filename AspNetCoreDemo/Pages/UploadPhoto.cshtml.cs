using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreDemo.Pages
{

    public class UploadPhotoModel : PageModel
    {
        public IFormFile Photo { get; set; }  // Contains file uploaded 
        public IWebHostEnvironment Env { get; }

        public UploadPhotoModel(IWebHostEnvironment Env)  // DI 
        {
            Console.WriteLine(Env.GetType().Name);
            this.Env = Env;
        }
        public void OnPost()
        {
            var filePath = Env.WebRootPath + "/photos/" + Photo.FileName;
            Console.WriteLine(filePath);

            using (var stream = System.IO.File.Create(filePath))
            {
                Photo.CopyTo(stream); // Make a copy of uploaded file 
            }
        }
    }
}
