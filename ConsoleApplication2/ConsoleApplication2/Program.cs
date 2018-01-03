using System;
namespace ConsoleApplication2
{
    class Program
    {
        public int i = 100;
        public int j;
        static void Main(string[] args)
        {
            int i = 10;
            Program obj1 = new Program();
            Program obj2 = new Program();
            obj1.i = 25;
            A a = new A();
            Console.WriteLine("Before " + obj1.i + "  and " + obj2.i);
            Console.WriteLine(" obj 1 : " + obj1.GetHashCode() + " obj2 : " + obj2.GetHashCode());
            a.method(ref i,obj1, ref obj2);
            Console.WriteLine("After " + obj1.i + " and " + obj2.i);
            Console.WriteLine(i + " obj 1 : " + obj1.GetHashCode() + " obj2 : " + obj2.GetHashCode());
            Console.ReadKey();
        }
    }
}
