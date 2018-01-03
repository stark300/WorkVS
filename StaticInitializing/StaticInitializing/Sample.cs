using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInitializing
{
    class Sample
    {
        static int i = getvalue();

        private static int getvalue()
        {
            Console.WriteLine("returning value for i");
            return 10;
        }
    }
}
