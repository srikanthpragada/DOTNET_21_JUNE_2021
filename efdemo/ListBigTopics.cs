using efdemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class ListBigTopics 
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();

            // LINQ To Entities 
            var topics = from t in ctx.Topics
                         where t.Hours > 5
                         orderby t.Name 
                         select t.Name;

            
            foreach(var t in topics)
                Console.WriteLine(t);
        }
    }
}
