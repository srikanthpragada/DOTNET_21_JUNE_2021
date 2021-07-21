using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webdemo.Pages
{
    public class PriceModel : PageModel
    {
        public int NetPrice { get; set; }
        public void OnGet(int price, int discount)
        {
            NetPrice = price - (price * discount / 100);
        }
    }
}
