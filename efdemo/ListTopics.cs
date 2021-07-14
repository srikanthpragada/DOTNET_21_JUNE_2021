using efdemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class ListTopics
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();
            
            // Eager load
            foreach(var t in ctx.Topics.Include("Course"))
                Console.WriteLine("{0} - {1} - {2}",
                        t.Course.Title, t.Name, t.Hours);
        }
    }
}
