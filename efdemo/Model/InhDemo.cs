using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efdemo.Model
{
    
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
     }
    class FulltimeEmployee : Employee
    {
        public int Salary { get; set; }
    }
    class Consultant : Employee
    {
        public int Hours { get; set; }
    }
    class InhDemo
    {
        static void Main(string[] args)
        {
            var ctx = new HRContext();
            var fe = new FulltimeEmployee { Name = "Roberts", Salary = 2500000 };
            var ce = new Consultant { Name = "Andy", Hours = 20 };
            ctx.Employees.Add(ce);
            ctx.Employees.Add(fe);
            ctx.SaveChanges();
        }
    }
}
