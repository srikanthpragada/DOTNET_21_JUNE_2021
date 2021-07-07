using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ExceptionsDemo
    {
        static void Main(string[] args)
        {
            int a = 10, b;
            try
            {
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Invalid operations. Division by zero!");
            }
            finally
            {
                Console.WriteLine("Finally!");
            }
          
            Console.WriteLine("The End");
        }
    }
}
