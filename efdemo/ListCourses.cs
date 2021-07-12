using efdemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class ListCourses
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();
            
            foreach(var c in ctx.Courses)
                Console.WriteLine(c.Title);
        }
    }
}
