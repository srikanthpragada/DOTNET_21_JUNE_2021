using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now);
            var enddate = now.AddDays(30);
            Console.WriteLine(enddate);

            var startdate = "01-01-2021";

            var sd = DateTime.Parse(startdate);
            Console.WriteLine(sd);

            var gap = now.Subtract(sd);  // TimeSpan
            Console.WriteLine(gap.Days);


        }
    }
}
