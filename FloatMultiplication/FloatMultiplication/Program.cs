using System;


namespace FloatMultiplication
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

            Multiplication multipy = new Multiplication();

            //Function call to multiply binary Strings.
            string product = multipy.BinaryMultiplication(floatString1, floatString2);
            Console.WriteLine("Binary representaion of result : "+product);

            //Converting the multiplied binary string to float
            float result = convert.ToFloatNumber(product);
            Console.WriteLine("final result in float : "+result);
            Console.ReadKey();
        
        }
    }
}
