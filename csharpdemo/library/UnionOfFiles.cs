using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class UnionOfFiles
    {
        static void Main(string[] args)
        {
            var lines = new HashSet<string>();

            var firstLines = File.ReadAllLines(@"c:\classroom\jun21\csharpdemo\library\file1.txt");
            foreach (var line in firstLines)
                lines.Add(line);

            var secondLines = File.ReadAllLines(@"c:\classroom\jun21\csharpdemo\library\file1.txt");
            foreach (var line in secondLines)
                lines.Add(line);


            foreach (var line in lines)
                Console.WriteLine(line);

        }
    }
}
