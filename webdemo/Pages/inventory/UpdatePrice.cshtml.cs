using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webdemo.Model;

namespace webdemo.Pages.inventory
{
    public class UpdatePriceModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        public string Message { get; set; }
        public void OnPost(InventoryContext dbContext)
        {
            var product = dbContext.Products.Find(Id);
            if (product == null)
            {
                Message = "Sorry! Product Id Not Found";
                return;
            }

            product.Price = Price;
            dbContext.SaveChanges();
            Message = "Updated price succeesfully!";
        }
    }
}
