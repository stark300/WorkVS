using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public int i = 100;
        static void Main(string[] args)
        {
            int i = 10;
            Program obj1 ;
            Program obj2 = new Program();
            //obj1.i = 25;
            A a = new A();
            Console.WriteLine("Before  and " + obj2.i);
            Console.WriteLine(" obj 1 : obj2 : "+obj2.GetHashCode());
            a.method(i,out obj1, ref obj2);

            Console.WriteLine("After " + obj1.i + " and " + obj2.i);
            Console.WriteLine(" obj 1 : " + obj1.GetHashCode() + "obj2 : " + obj2.GetHashCode());
            Console.ReadKey();
        }
    }
}
