using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading the floating numbers.
            Console.WriteLine("Enter 1st floating number : ");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd floating number : ");
            float number2 = float.Parse(Console.ReadLine());

            Conversion convert = new Conversion();

            //Converting each Floating number to corresponding Binary strings.
            string floatString1 = convert.ToFloatString(number1);
            Console.WriteLine("Binary representaion of 1st number : " + floatString1);
            string floatString2 = convert.ToFloatString(number2);
            Console.WriteLine("Binary representaion of 2nd number : " + floatString2);

            Addition add = new FloatAddition.Addition();
            string sum = "";
            if (number1 >= 0 && number2 >= 0 || number1 <= 0 && number2 <= 0)
            {
                sum = add.AddBinary(floatString1, floatString2);
            }
            else
            {
            }

            float result = convert.ToFloatNumber(sum);
            Console.WriteLine("final result in float : " + result);
            Console.ReadKey();
        }
    }
}
