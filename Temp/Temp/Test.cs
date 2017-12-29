using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public struct emp
    {
        public static string name ;
        public int emp_no;
        
        public void Func()
        {
            Console.WriteLine("hey");
        }
    }
    class Test
    {
        
        static int counter=0;
        public Test()
        {
            counter++;
        }

        public int getCounter()
        {
            return counter;
        }
    }
}
