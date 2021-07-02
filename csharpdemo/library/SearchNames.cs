using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class SearchNames
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader(@"c:\classroom\jun21\names.txt"))
            {
                Console.Write("Enter search string :");
                var pattern = Console.ReadLine();
                pattern = pattern.ToUpper();

                while (true)
                {
                    var name = sr.ReadLine();
                    if (name == null)  // EOF 
                        break;

                    // Check whether name contains pattern without case sensitivity 
                    if (name.ToUpper().Contains(pattern))
                        Console.WriteLine(name);
                }
            }

        }
    }
}
