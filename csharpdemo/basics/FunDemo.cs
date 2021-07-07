using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class FunDemo
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Wish(String name = "Guest", String message = "Hello")
        {
            Console.WriteLine($"{message} {name}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 20));
            Wish("Scott", "Hi");
            Wish("Steve");
            Wish();
            Wish(message : "Hi");  // Pass value by name 
        }
    }
}
