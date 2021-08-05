using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books.Pages
{
    public class GetBookModel : PageModel
    {
       

        private CatalogContext Context;
        public int Count { get; set; }

        public GetBookModel(CatalogContext ctx)
        {
            Context = ctx;
        }

        public IActionResult OnGet(int id)
        {   
            var book = Context.Books.Find(id);
            if (book == null)
                return new JsonResult(null);
            else
                return new JsonResult(book);
        }
    }
}
