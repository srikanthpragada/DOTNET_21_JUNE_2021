using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo.Model
{
    class ListConsultants
    {
        static void Main(string[] args)
        {
            var ctx = new HRContext();
            foreach(var e in ctx.Consultants)
                Console.WriteLine(e.Name);
        }
    }
}
