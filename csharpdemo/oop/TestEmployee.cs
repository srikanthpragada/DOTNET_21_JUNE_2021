using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    abstract class Employee
    {
        private String name, desg;
        public Employee(String name, String desg)
        {
            this.name = name;
            this.desg = desg;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.desg);
        }

        public abstract int GetPay();
         
    }

    class SalariedEmployee : Employee
    {
        private int salary;
        public SalariedEmployee(String name, String desg, int salary)
            : base(name, desg)    // call base class constructor 
        {
            this.salary = salary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.salary);
        }

        public override int GetPay()
        {
            return this.salary;
        }
    }
    class Consultant : Employee
    {
        private int rate, hours;
        public Consultant(String name, String desg, int rate, int hours)
            : base(name, desg)    // call base class constructor 
        {
            this.rate = rate;
            this.hours = hours;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.rate);
            Console.WriteLine(this.hours);
        }

        public override int GetPay()
        {
            return this.rate * this.hours;
        }
    }

    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee e = new SalariedEmployee("Mark", "Programmer", 700000);
            e.Print();  // Runtime polymorphism
            Console.WriteLine(e.GetPay());

            e = new Consultant("Tom", "DBA", 20, 2000);
            e.Print();  // Runtime polymorphism
            Console.WriteLine(e.GetPay());
        }
    }
}
