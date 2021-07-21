using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webdemo.Pages
{

    public class TableModel : PageModel
    {
        [FromQuery]
        public int Number { get; set; }

        [FromQuery]
        public int Length { get; set; }
        public void OnGet()
        {
            if (Length == 0)
                Length = 10;
        }
    }
}
