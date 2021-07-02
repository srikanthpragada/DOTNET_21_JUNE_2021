using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class WriteNames
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter(@"c:\classroom\jun21\names.txt"))
            {
                while (true)
                {
                    Console.Write("Enter name [end to stop] :");
                    var name = Console.ReadLine();
                    if (name == "end")
                        break;

                    sw.WriteLine(name);
                }
            }

        }
    }
}
