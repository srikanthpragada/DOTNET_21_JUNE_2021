using efdemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class ListTopicsByCourse
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();

            // LINQ To Entities 
            var topics = from t in ctx.Topics.Include("Course")
                         where t.Course.Fee > 5000
                         select  new { CourseTitle = t.Course.Title, TopicName = t.Name};

            
            foreach(var t in topics)
                Console.WriteLine("{0} - {1}", t.CourseTitle, t.TopicName);
        }
    }
}
