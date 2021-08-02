using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Pages
{
    public class IndexModel : PageModel
    {
        private CatalogContext context;
        public int Count { get; set; }

        public IndexModel(CatalogContext ctx)
        {
            context = ctx;
        }

        public void OnGet()
        {
            Count = context.Books.Count();
        }
    }
}
