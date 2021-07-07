using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class PassByReference
    {
        static void Swap(ref int n1, ref int n2)
        {
            int temp;

            temp = n1;
            n1 = n2;
            n2 = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;

            Swap(ref a, ref b);   // Pass a,b by reference 
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
