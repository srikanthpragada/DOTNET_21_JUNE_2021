using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.advanced
{
    class SearchArrayUsingDelegate
    {
        static bool LengthyString(string s)
        {
            return s.Length > 4;
        }

        static bool HasSpecialChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!Char.IsLetterOrDigit(s[i]))
                    return true;

            return false;
        }

        static void Main(string[] args)
        {
            string[] names = { "Java", "JavaScript","Python",
                               "C#", "C++", "Ruby", "TypeScript" };

            var bignames = Array.FindAll(names, LengthyString);  // Array, Predicate 

            foreach (var n in bignames)
                Console.WriteLine(n);


            var specialames = Array.FindAll(names, HasSpecialChar);  // Array, Predicate
            foreach (var n in specialames)
                Console.WriteLine(n);
        }

    }
}
