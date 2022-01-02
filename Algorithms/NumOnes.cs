using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class NumOnes
	{
        public static int HammingWeight2(uint n)
        {
            var asString = Convert.ToString(n, 2);
			var numOnes = 0;

			foreach (var letter in asString)
			{
				if (letter == '1')
				{
					numOnes++;
				}
			}
			return numOnes;
        }
        public static int HammingWeight(uint n)
        {
            uint numOnes = 0;
            while(n!=0)
            {
                numOnes += (n & 1);
                n = n >> 1;
            }
            return (int)numOnes;
            //uint numOnes = 0;
            //for (var count = 1; count <= 32; count++)
            //{
            //    numOnes += (n & 1);
            //    n = n >> 1;
            //}
            //return (int)numOnes;
        }
        public int HammingDistance(int x, int y)
        {
            var different = x ^ y;
            var numOnes = 0;
            while (different != 0)
            {
                numOnes += (different & 1);
                different = different >> 1;
            }
            return numOnes;

        }
    }
}
