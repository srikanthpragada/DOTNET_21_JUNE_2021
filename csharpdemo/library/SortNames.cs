using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class SortNames
    {
        static void Main(string[] args)
        {
            var file = File.OpenText(@"c:\classroom\jun21\names.txt");
            var names = new SortedSet<String>();

            while (true)
            {
                var line = file.ReadLine();
                if (line == null)
                    break;

                var linenames = line.Split(',');
                foreach (var n in linenames)
                    names.Add(n.Trim());
            }

            file.Close();

            foreach(var n in names)
                Console.WriteLine(n);
        }
    }
}
