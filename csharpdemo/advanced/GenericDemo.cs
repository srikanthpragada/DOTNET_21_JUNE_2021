using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.advanced
{
    class GenericDemo
    {
        static void Main(string[] args)
        {
            Print("Hello!");
            Print(100);
            Print(DateTime.Now);
        }

        static void Print<T> (T value)
        {

        }

        //static void Print(string message)
        //{

        //}

        //static void Print(DateTime value)
        //{

        //}
    }
}
