using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webdemo.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public string Now { get; set; }
        public void OnGet()   // Executed when a request is made 
        {
            Message = "Welcome to Asp.Net Core";
            Now = DateTime.Now.ToString();
        }
    }
}
