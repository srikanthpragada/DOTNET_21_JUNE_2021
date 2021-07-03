using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.advanced
{
    class LambdaDemo
    {
        static void Main(string[] args)
        {
            string[] names = { "Java", "JavaScript","Python",
                               "C#", "C++", "Ruby", "TypeScript" };

            var bignames = Array.FindAll(names, s => s.Length > 4);  // Array, Predicate 

            var bignames2 = Array.FindAll(names,
                delegate(String s)
                {
                    return s.StartsWith("J");
                }
            );
            foreach (var n in bignames)
                Console.WriteLine(n);

 
        }

    }
}
