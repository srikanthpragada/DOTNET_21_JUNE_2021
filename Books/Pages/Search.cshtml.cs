using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class SearchModel : PageModel
    {
        [BindProperty]
        [Required]
        public string Title { get; set; }

        [Required]
        [BindProperty]
        public string Author { get; set; }

        public void OnGet()
        {
        }
 
    }
}
