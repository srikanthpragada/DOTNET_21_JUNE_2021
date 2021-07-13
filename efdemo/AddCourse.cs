using efdemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class AddCourse
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();
            var course = new Course { Title = "Python", Fee = 5000 };

            ctx.Courses.Add(course);   // State to Added
            ctx.SaveChanges();         // Insert command 
        }
    }
}
