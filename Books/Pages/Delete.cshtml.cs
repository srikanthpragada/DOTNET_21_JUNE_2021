using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class DeleteModel : PageModel
    {
        public string Message { get; set; }
        public CatalogContext Context { get; set; }
      
        public DeleteModel(CatalogContext ctx)
        {
            Context = ctx;
        }
        public void OnGet(int? id)
        {
            if (id == null)
            {
                Message = "Sorry! Book id not found!";
                return;
            }

         
            // Get book with given id
            var book = Context.Books.Find(id);
            if (book == null)
            {
                Message = "Sorry! Book id not found!";
                return;
            }

            // Delete book 
            Context.Books.Remove(book);
            Context.SaveChanges();

            Message = $"[{book.Title}] was deleted successfully!";
        }
    }
}
