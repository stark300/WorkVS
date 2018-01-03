using System;
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
            //Converting each Floating number to corresponding Binary strings.
            Conversion convert = new Conversion();
            string floatString1 = convert.ToFloatString(number1);
            Console.WriteLine("Binary representaion of 1st number : " + floatString1);
            string floatString2 = convert.ToFloatString(number2);
            Console.WriteLine("Binary representaion of 2nd number : " + floatString2);
            // Adding the binary strings.
            Addition add = new FloatAddition.Addition();
            string sum = add.AddBinary(floatString1, floatString2);
            float result = convert.ToFloatNumber(sum);
            Console.WriteLine("final result in float : " + result);
            Console.ReadKey();
        }
    }
}
