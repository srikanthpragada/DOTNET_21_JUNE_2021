using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.advanced
{
    public delegate void PrintDelegate(string message);  // 1
    class DelegatesDemo
    {
        static void Show(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            var d = new PrintDelegate(Show);     // 2
            PrintDelegate d2 = Show;             // Method group conversion
            d("Hello!");                         // 3
            d.Invoke("Hi");
            d2("GoodBye");
        }
    }
}
