using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class A
    {
        public void method(int i,out Program obj1, ref Program obj2)
        {

            obj1 = new Program();
            obj1.i = 50;
            obj2 = new Program();
            obj2.i = 50;
        }
    }
}
