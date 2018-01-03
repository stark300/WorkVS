﻿using System;
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
                    binary1 = '0' + binary2;
                    paddingBits--;
                }
            }
            binary1 = binary1.Replace(".", "");
            binary2 = binary2.Replace(".", "");
            string result = "";
            if( operation == "add")
            {
                result = Add(binary1, binary2);
            }
            else
            {
                if(sign1 == '0')
                {
                    Subtract(binary1, binary2);
                }
                else
                {
                    Subtract(binary2, binary1);
                }
            }
            return result;
        }

        private string Subtract(string binary1, string binary2)
        {
            binary2 = TwosCompliment(binary2);
        }

        private string TwosCompliment(string binary2)
        {
            StringBuilder binaryString = new StringBuilder(binary2);
            for(int index = 0; index <= binaryString.Length - 1; index++)
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
