using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            Random random = new Random();
            for(int i = 0; i < a.Length; i ++)
            {
                a[i] = random.Next(100);
                Console.Write($"{a[i]} ");
            }

            Array.Sort(a);

            Console.WriteLine("\nSorted Array");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }

            int pos = Array.BinarySearch(a, 20);
            Console.WriteLine($"\n20 is at : {pos}");

        }
    }
}
