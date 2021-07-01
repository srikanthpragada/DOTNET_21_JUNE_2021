using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            String s1 = "Abcdef";
            String s2 = "bcd";

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.CompareTo(s2));
        }
    }
}
