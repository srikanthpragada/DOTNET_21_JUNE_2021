using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; init; }   // Init-only property 

        public int MyProperty { get; set; }
    }

    class AutoPropDemo
    {
        static void Main(string[] args)
        {
            Circle p1 = new Circle();
            p1.X = 10;
            p1.Y = 20;
            // p1.Radius = 20;

            var p2 = new Circle { X = 1, Y = 2 , Radius = 10};

        }
    }
}
