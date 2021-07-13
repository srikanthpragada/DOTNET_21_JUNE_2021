using efdemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo
{
    class DeleteCourse
    {
        static void Main(string[] args)
        {
            var ctx = new TrainingContext();
            var course = ctx.Courses.Find(1002);  // Get course with id 1 
            if (course == null)
                Console.WriteLine("Sorry! Course id not found!");
            else
            { 
                // State is Unchanged 
                ctx.Courses.Remove(course);    // State is Deleted 
                ctx.SaveChanges();             // Delete 
            }
        }
    }
}
