using efdemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class UpdateCourse
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();
            var course = ctx.Courses.Find(1);  // Get course with id 1 
            if (course == null)
                Console.WriteLine("Sorry! Course id not found!");
            else
            { 
                // State is unchanged 
                course.Fee = 11000;   // State is Modified
                ctx.SaveChanges();    // Update 
            }
        }
    }
}
