using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class VaryingArgs
    {
        static void Wish(String message, params String [] names)
        {
            foreach(var name in names)
               Console.WriteLine($"{message} {name}");
        }
        static void Main(string[] args)
        {
            Wish("Hello", "Bill", "Larry", "Bob");
        }
    }
}
