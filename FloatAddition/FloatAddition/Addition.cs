using System;
using System.Text;

namespace FloatAddition
{
    class Addition
    {
        public string AddBinary(string binary1, string binary2)
        {
            char sign1 = binary1[0];
            char sign2 = binary2[0];
            String operation = sign1 == sign2 ? "add" : "subtract";
            binary1 = binary1.Remove(0, 1);
            binary2 = binary2.Remove(0, 1);
            int pointPosition1 = binary1.IndexOf(".");
            int pointPosition2 = binary2.IndexOf(".");
            int finalPointPosition;
            int paddingBits = Math.Abs(pointPosition1 - pointPosition2);
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
            Console.WriteLine("check : "+result);
            result = result.Insert(result.Length - 23, ".");
            return result;
        }

        private string Subtract(string binary1, string binary2)
        {
            binary2 = TwosCompliment(binary2);
            string result = "";

            result = Add(binary1, binary2);
            int carry = result.Length - binary1.Length;
            if(carry == 1)
            {
                result = result.Remove(0, 1);
                return '0' + result;
            }
            else
            {
                result = TwosCompliment(result);
                return '1' + result;
            }
        }

        private string TwosCompliment(string binary2)
        {
            StringBuilder binaryStringBuilder = new StringBuilder(binary2);
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
            binaryString = Add(binaryString, "1");
            return binaryString;
        }

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
