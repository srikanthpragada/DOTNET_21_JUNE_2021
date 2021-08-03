using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class AddBookModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }
        public CatalogContext Context { get; set; }
        public string Message { get; set; }
        public AddBookModel(CatalogContext ctx)
        {
            Context = ctx; 
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Context.Books.Add(Book);
                Context.SaveChanges();
                Message = Book.Title + " has been added successfully!";
            }

        }
    }
}
