using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class SortCustomers
    {
        static void Main(string[] args)
        {
            string[] data = { "Abc,393933333", "Xyz,92919133", "Pqr,393949434", "Def,392919444" };
            var customers = new SortedDictionary<string, string>();

            foreach(var entry in data)
            {
                var parts = entry.Split(',');
                customers.Add(parts[0], parts[1]);  // First part is name, second is number
            }

            foreach(var name in customers.Keys)
                Console.WriteLine($"{name}  - {customers[name]}");

        }
    }
}
