using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.library
{
    class Person : IComparable<Person>
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }

        public override bool Equals(object obj)
        {
            var other = obj as Person;    // Downcasting 
            return this.Name == other.Name && this.Age == other.Age;
        }

        public int CompareTo(Person other)
        {
            return this.Age - other.Age; 
        }
    }

    class TestPerson
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "Steve", Age = 30 };
            var p2 = new Person { Name = "Bob", Age = 25 };
            var p3 = new Person { Name = "Bob", Age = 25 };

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p2.Equals(p3));
            Console.WriteLine(p1.CompareTo(p2));

        }
    }
}
