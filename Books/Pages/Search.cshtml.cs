using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class SearchModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Author { get; set; }

        public List<Book> Books { get; set; }
        public CatalogContext Context { get; set; }
        public string Message { get; set; }
        public SearchModel(CatalogContext ctx)
        {
            Context = ctx;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Title is null)
                Title = "";

            if (Author is null)
                Author = "";

            Books = Context.Books
                  .Where(b => b.Title.Contains(Title) && b.Author.Contains(Author))
                  .ToList<Book>();

           
        }

    }
}
