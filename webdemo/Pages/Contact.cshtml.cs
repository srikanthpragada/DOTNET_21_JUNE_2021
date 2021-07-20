using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webdemo.Pages
{
    public class ContactModel : PageModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public void OnGet()
        {
            Name = "Srikanth Pragada";
            Email = "srikanthpragada@gmail.com";
            Mobile = "9059057000";
        }
    }
}
