using efdemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class ListProducts
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();

            // Eager load
            foreach (var p in ctx.Products)
                Console.WriteLine("{0} - {1}", p.Id, p.Name);
        }
    }
}
