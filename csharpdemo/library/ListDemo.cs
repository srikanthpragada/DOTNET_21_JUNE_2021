using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            var names = new List<String>();

            names.Add("Bill");
            names.Add("Larry");
            names.Add("Mark");
            names.Insert(0, "Steve");
            names.Remove("Bill");
            names.RemoveAt(0);
 
            foreach(var n in names)
                Console.WriteLine(n);
        }
    }
}
