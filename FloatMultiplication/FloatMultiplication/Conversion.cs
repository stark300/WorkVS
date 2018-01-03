using System;
namespace FloatMultiplication
{
    class Conversion
    {
        /// <summary>
        /// Converting the float numbers to binary
        /// </summary>
        /// <param name="floatNumber"> contains the number to be converted</param>
        /// <param name="integral"> stores the integeral part of float</param>
        /// <param name="fraction"> stores the fractional part of float</param>
        /// <returns name="floatString"> Binary Respresentation of float</returns>
        public string ToFloatString (float floatNumber)
        {
            string floatString = string.Empty;
            int integral = (int)floatNumber;
            float fraction = floatNumber - integral;
            floatString =  integral >= 0 ?  "0" : "1";
            // Handling the negative numbers
            if(integral < 0)
            {
                integral = integral * -1;
                fraction = fraction * -1;
            }
            // Converting the integral part directly using inbuilt function.
            floatString = floatString + Convert.ToString(integral, 2);
            floatString = floatString + ".";
            // FloatBits to store number of precession
            int floatBits = 23;
            // Converting fractional part to binary
            while (floatBits > 0)
            {
                fraction = fraction * 2;
                floatString = floatString + ((int)fraction).ToString();
                fraction = fraction - (int)fraction;
                floatBits--;
            }
            Console.WriteLine("the float string is " + floatString);
            return floatString;
        }
        /// <summary>
        /// Converting the binary numbers to float.
        /// </summary>
        /// <param name="binaryFloat"></param>
        /// <param name="integralPart"> stores the integeral part of binary float</param>
        /// <param name="fractionPart"> stores the fractional part of binary float</param>
        /// <returns> value of sum of integral part and floating part </returns>
        public float ToFloatNumber(string binaryFloat)
        {
            int sign = (binaryFloat[0] == binaryFloat[0]) ? 1 : -1;
            binaryFloat = binaryFloat.Remove(0, 1);
            int prescisionPosition = binaryFloat.IndexOf(".");
            int integralResult = 0;
            float fractionalResult = 0;
            string integralPart = binaryFloat.Substring(0,prescisionPosition);
            string fractionalPart = binaryFloat.Substring(prescisionPosition+1);
            int count = 0;
            // Converting integral part to decimal.
            for (int i = integralPart.Length - 1; i >= 0; i--)
            {
                integralResult = integralResult + (integralPart[i] - '0') * (int)Math.Pow(2, count);
                count++;
            }
            count = -1;
            // Converting fraction part to decimal.
            for (int i = 0; i < fractionalPart.Length; i++)
            {
                fractionalResult = fractionalResult + (fractionalPart[i] - '0') * (float)Math.Pow(2, count);
                count--;
            }
            // Adding the sign to the result.
            return sign * (integralResult + fractionalResult);
        }
    }
}
