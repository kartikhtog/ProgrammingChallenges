using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	// Find two item that add up.
	public class icecreamParlorClass
	{
        /*
 * Complete the 'icecreamParlor' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER m
 *  2. INTEGER_ARRAY arr
 */

        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            var list = new List<int>(arr);
            arr.Sort();
            var lowIndex = 0;
            var highIndex = arr.Count - 1;
            var found = false;
            var sum = 0;
            while (!found)
			{
                sum = arr[lowIndex] + arr[highIndex];
                if (sum > m)
				{
                    highIndex--;
				}
                else if (sum < m)
				{
                    lowIndex++;
				}
				else
				{
                    found = true;
				}

			}
            var sortedAns = new List<int> { list.FindIndex(x => x == arr[lowIndex]) + 1, list.FindLastIndex(x => x == arr[highIndex]) + 1 };
            sortedAns.Sort();
            return sortedAns;
        }

	}
}
