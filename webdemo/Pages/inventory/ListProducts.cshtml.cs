using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webdemo.Model;

namespace webdemo.Pages.inventory
{
    public class ListProductsModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet(InventoryContext dbContext)
        {
            Products = dbContext.Products.ToList();
        }
    }
}
