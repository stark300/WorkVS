using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class Program
    {
        static int y = 5;
        static int x = y;
        
        static void Main(string[] args)
        {
            //Test test = new Test();
            //Console.WriteLine(test.getCounter());
            //Test test1 = new Test();
            //Console.WriteLine(test1.getCounter());
            //Test test2 = test1;
            //Console.WriteLine(test1.getCounter());

            //emp e;
            //Console.WriteLine(e.name == null);
            //e.emp_no = 1;
            //Console.WriteLine(e.name);
            //e.Func();
            //Console.ReadKey();

            Console.WriteLine(Program.x);
            Console.WriteLine(Program.y);

            Program.x = 99;
            Console.WriteLine(Program.x);
            Console.ReadKey();
        }
    }
}
