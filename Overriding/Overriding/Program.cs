using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class BaseClass
    {
        public  void print()
        {
            Console.WriteLine("base class print");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void print()
        {
            Console.WriteLine("der class print");
        }
    }
  

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new DerivedClass();
            obj.print();
            Console.ReadKey();
        }
    }
}
