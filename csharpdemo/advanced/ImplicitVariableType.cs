using csharpdemo.oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.advanced
{
    class ImplicitVariableType
    {
        static void Main(string[] args)
        {
            var num = 10;
            var a1 = new Account(1,"Abc");
            // num = 10.40;
        }
    }
}
