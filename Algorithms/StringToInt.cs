using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StringToInt
    {
        public int MyAtoi(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }
            s = s.Trim();
            var isPositive = true;
            var index = 0;
            var value = 0;
            if (s[index] == '-' || s[index] == '+')
            {
                if (s[index] == '-')
                {
                    isPositive = false;
                }
                index++;
            }
            var numDetected = false;
            var startIndex = index;
            for (; index < s.Length; index++)
            {

                if (s[index] == '0' && !numDetected)
                {
                    startIndex = index;
                }
                else if (s[index] - '0' > 9 || s[index] - '0' < 0)
                {
                    break;
                }
                else
                {
                    numDetected = true;
                }
            }

            var length = index;
            index = startIndex;

            for (; index < length; index++)
            {
                try
                {
                    value = !isPositive ? checked((value * 10) - (s[index] - '0')) : checked((value * 10) + (s[index] - '0'));
                }
                catch
                {
                    if (isPositive)
                    {
                        value = int.MaxValue;
                    }
                    else
                    {
                        value = int.MinValue;
                    }
                    break;
                }

                //Console.WriteLine(string.Format("{0:0,0}", value));
            }

            return value;
        }
        int Pow(int baseNumber, int exponent)
        {
            return (int)Math.Pow((double)baseNumber, (double)exponent);
        }

    }
}
