using System;
using System.Text;
namespace FloatAddition
{
    /// <summary>
    /// Class To take care of addition of binaries.
    /// </summary>
    class Addition
    {
        /// <summary>
        /// Based on the binary numbers the  
        /// values are added or subtracted.
        /// </summary>
        /// <param name="binary1">Stroes the first binary number.</param>
        /// <param name="binary2">Stroes the second binary number.</param>
        /// <returns name="result">value of summed binary</returns>
        public string AddBinary(string binary1, string binary2)
        {
            char sign1 = binary1[0];
            char sign2 = binary2[0];
            // If the signs are similar peform the sum.
            // If the signs are dissimilar perform subtraction.
            String operation = sign1 == sign2 ? "add" : "subtract";
            binary1 = binary1.Remove(0, 1);
            binary2 = binary2.Remove(0, 1);
            // Keeping track of the pointer position.
            int pointPosition1 = binary1.IndexOf(".");
            int pointPosition2 = binary2.IndexOf(".");
            int finalPointPosition;
            int paddingBits = Math.Abs(pointPosition1 - pointPosition2);
            // Padding bits to the smaller number and updating the final point position.
            if(pointPosition1 > pointPosition2)
            {
                finalPointPosition = pointPosition2;
                while (paddingBits > 0)
                {
                    binary2 = '0' + binary2;
                    paddingBits--;
                }
            }
            else
            {
                finalPointPosition = pointPosition1;
                while (paddingBits > 0)
                {
                    binary1 = '0' + binary1;
                    paddingBits--;
                }
            }
            binary1 = binary1.Replace(".", "");
            binary2 = binary2.Replace(".", "");
            string result = "";
            // Checking whether to add or subtract
            if( operation.Equals("add"))
            {
                result = Add(binary1, binary2);
                result = sign1 + result;
            }
            else
            {
                if(sign1 == '0')
                {
                    result = Subtract(binary1, binary2);
                }
                else
                {
                    result = Subtract(binary2, binary1);
                }
            }
            result = result.Insert(result.Length - 23, ".");
            return result;
        }
        /// <summary>
        /// Method to subtract two binary numbers.
        /// </summary>
        /// <param name="minuend">stores the minuend</param>
        /// <param name="subtrahend">stores the subtrahend</param>
        /// <returns>The subtracted value</returns>
        private string Subtract(string minuend, string subtrahend)
        {
            // 2's complimenting the subtrahend.
            subtrahend = TwosCompliment(subtrahend);
            string result = "";
            result = Add(minuend, subtrahend);
            int carry = result.Length - minuend.Length;
            // Checking if carry exists.
            if(carry == 1)
            {
                result = result.Remove(0, 1);
                return '0' + result;
            }
            else
            {
                // If there is no carry then 2's compliment the result.
                result = TwosCompliment(result);
                return '1' + result;
            }
        }
        /// <summary>
        /// Used to calculate 2's compliment of a number.
        /// </summary>
        /// <param name="subtrahend">Stores the value of subtrahend</param>
        /// <returns>2's compliment of the number</returns>
        private string TwosCompliment(string subtrahend)
        {
            StringBuilder binaryStringBuilder = new StringBuilder(subtrahend);
            // Performing 1's compliment.
            for(int index = 0; index <= binaryStringBuilder.Length - 1; index++)
            {
                if(binaryStringBuilder[index] == '0')
                {
                    binaryStringBuilder[index] = '1';
                }
                else
                {
                    binaryStringBuilder[index] = '0';
                }
            }
            String binaryString = binaryStringBuilder.ToString();
            // Adding 1 to the 1's compliment.
            binaryString = Add(binaryString, "1");
            return binaryString;
        }
        /// <summary>
        /// Method to add two binary numbers
        /// </summary>
        /// <param name="binary1">First binary number</param>
        /// <param name="binary2">Seconf binary number</param>
        /// <returns>sum of two binary numbers</returns>
        private string Add(string binary1, string binary2)
        {
            string result = "";
            int sum = 0;
            //string length of each binary string
            int length1 = binary1.Length - 1, length2 = binary2.Length - 1;
            while (length1 >= 0 || length2 >= 0 || sum == 1)
            {
                sum += ((length1 >= 0) ? binary1[length1] - '0' : 0);
                sum += ((length2 >= 0) ? binary2[length2] - '0' : 0);
                result = (sum % 2).ToString() + result;
                sum /= 2;
                length1--;
                length2--;
            }
            return result;
        }
    }
}
