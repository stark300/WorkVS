using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class A
    {
        public void method(ref int i,Program obj1, ref Program obj2)
        {
            Console.WriteLine("IN A obj 1 : " + obj1.GetHashCode() + " obj2 : " + obj2.GetHashCode());
            i += 200;
            obj1 = new Program();
            obj1.i = 50;
            obj2 = new Program();
            obj2.i = 50;
            obj1.i = obj2.i;
            Console.WriteLine("IN A obj 1 : " + obj1.GetHashCode() + " obj2 : " + obj2.GetHashCode());
            B b = new B();
            b.method(ref obj2);
        }
    }
}
