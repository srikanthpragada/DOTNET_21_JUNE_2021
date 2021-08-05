using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class ListModel : PageModel
    {
        public List<Book> Books { get; set; }
        public CatalogContext Context { get; set; }
        public string Message { get; set; }
        public ListModel(CatalogContext ctx)
        {
            Context = ctx;
        }
        public void OnGet()
        {

            Books = Context.Books.ToList<Book>();
            Console.WriteLine("Obtained Books : " + Books.Count);

        }
    }
}
