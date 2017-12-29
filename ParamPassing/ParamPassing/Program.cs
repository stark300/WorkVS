using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamPassing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Sample s = new Sample();
            Console.WriteLine(s.NormalAdd(5, 10));

            Console.WriteLine(s.AddwithOut(out a, out b));

            int[] arr = new int[2];
            arr[0] = 0;
            arr[1] = 1;

            s.paramsMethod();
            s.paramsMethod(1, 2);
            s.paramsMethod('b', 1, 2);

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
