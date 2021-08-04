using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }
        public string Message { get; set; }
        public CatalogContext Context { get; set; }

        public EditModel(CatalogContext ctx)
        {
            Context = ctx;
        }
        public void OnGet(int? id)
        {
            Message = null;
            Book = null;

            if (id == null)
            {
                Message = "Sorry! Book id not found!";
                return;
            }


            // Get book with given id
            Book = Context.Books.Find(id);
            if (Book == null)
            {
                Message = "Sorry! Book id not found!";
                return;
            }
        }

        public IActionResult OnPost(int? id)
        {
            // Get book with given id
            var dbbook = Context.Books.Find(id);
            if (dbbook == null)
            {
                Book = null; 
                Message = "Sorry! Book id not found!";
                return Page();
            }

            dbbook.Title = Book.Title;
            dbbook.Author = Book.Author;
            dbbook.NoPages = Book.NoPages;
            dbbook.Remarks = Book.Remarks;
            dbbook.Rating = Book.Rating;

            Context.SaveChanges();   // UPDATE 
            return RedirectToPage("List");
        }
    }
}
