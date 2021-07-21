using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webdemo.Pages
{
    public class WishModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet(string name)
        {
            //var name = Request.Query["name"];

            //if (name.Count == 0)  // No parameter called name is passed 
            //    name = "Guest";

            if (name == null)
                name = "Guest";

            var hours = DateTime.Now.Hour;
            if (hours < 12)
                Message = "Good Morning";
            else
                if (hours < 16)
                Message = "Good afternoon";
            else
                Message = "Good Evening";


            Message = Message + " " + name;
        }
    }
}
