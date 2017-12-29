using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamPassing
{
    class Sample
    {
        public int NormalAdd(int a, int b)
        {
            return a + b;
        }

        internal int AddwithOut(out int a, out int b)
        {
            a = 5;
            b = 10;
            return a + b;
        }

        public void paramsMethod(int optionalint = 0,params int[] numbers)
        {
            Console.WriteLine(numbers.Length);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
