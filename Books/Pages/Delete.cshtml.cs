using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class DeleteModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet(int? id)
        {
            if (id == null)
            {
                Message = "Sorry! Book id not found!";
                return; 
            }

            // Delete book 

            Message = "Book was deleted successfully!";
        }
    }
}
