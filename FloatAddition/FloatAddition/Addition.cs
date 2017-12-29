using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatAddition
{
    class Addition
    {
        public string AddBinary(string binary1, string binary2)
        {
            char sign = binary2[0];
            binary1 = binary1.Remove(0, 1);
            binary2 = binary2.Remove(0, 1);

            int pointPosition1 = binary1.IndexOf(".");
            int pointPosition2 = binary2.IndexOf(".");
            int finalPointPosition = pointPosition2;
            int paddingBits = Math.Abs(pointPosition1 - pointPosition2);

            if(pointPosition1 > pointPosition2)
            {
                
                while(paddingBits > 0)
                {
                    finalPointPosition = pointPosition2;
                    binary2 = '0' + binary2;
                    paddingBits--;
                }
            }
            else
            {
                finalPointPosition = pointPosition1;
                while (paddingBits > 0)
                {
                    binary1 = '0' + binary2;
                    paddingBits--;
                }
            }


            binary1 = binary1.Replace(".", "");
            binary2 = binary2.Replace(".", "");

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
            
            result = result.Insert(result.Length - 23, ".");
            result = sign + result;
            Console.WriteLine(result);
            return result;
        }
    }
}
