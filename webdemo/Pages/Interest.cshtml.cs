using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webdemo.Pages
{
    public class InterestModel : PageModel
    {
        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public int Rate { get; set; }

        public int Interest { get; set; }
        public void OnPost()
        {
            Interest = Amount * Rate / 100; 
        }
    }
}
