using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatMultiplication
{
    class Multiplication
    {
        /// <summary>
        /// function to multiply the two binary strings
        /// </summary>
        /// <param name="binaryString1">First binary number</param>
        /// <param name="binaryString2">Second binary number</param>
        /// <returns>The multiplied strings in binary form</returns>
        internal string BinaryMultiplication(string binaryString1, string binaryString2)
        {
            String sign = (binaryString1[0] == binaryString2[0]) ? "0" : "1";

            //removing the sign bit
            binaryString1 = binaryString1.Remove(0, 1);
            binaryString2 = binaryString2.Remove(0, 1);

            //keeping track of floating point in the numbers
            int point_position1 = binaryString1.Length - binaryString1.IndexOf(".");
            int point_position2 = binaryString2.Length - binaryString2.IndexOf(".");
            int decimalPointPosition = point_position1 + point_position2;

            //removing the point.
            binaryString1 = binaryString1.Replace(".", "");
            binaryString2 = binaryString2.Replace(".", "");

            string result = "0";

            //loop to multiply the binary floats.
            for (int i = binaryString2.Length -1, j = 0; i >= 0; i--, j++)
            {
                int level = j;
                char digit = binaryString2[i];
                int position = binaryString1.Length - 1;
                string multiply = String.Empty;

                int digitPlace = binaryString1.Length - 1;
                //when multiplied  by 1 there is no change in the value.
                if(digit == '1')
                {
                    multiply = binaryString1;
                }
                //when multiplied by 0 every bit becomes zero.
                else
                {
                    while (digitPlace >= 0)
                    {
                        multiply += 0;
                        digitPlace--;
                    }

                }
                //Level is used to keep track of the number of zeros
                //to be added at each level in multiplication
                while (level > 0)
                {
                    multiply = multiply + "0";
                    level--;
                }

                //adding the consecutive multiplication passes.
                //result has the old multiplication pass value 
                //and multiply has the new multiplication pass value.
                result = AddBinary(result, multiply);
            }

            //adding back the removed signbit and floating point.
            result = sign + result;
            result = result.Insert(result.Length - decimalPointPosition + 2, ".");
            
            return result;
        }

        /// <summary>
        /// fucntion toad two binary numbers.
        /// </summary>
        /// <param name="binary1">value of presious pass</param>
        /// <param name="binary2">value to be added</param>
        /// <returns>value after current pass</returns>
        string AddBinary(string binary1, string binary2)
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
