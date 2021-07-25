using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Codility
{
    class Unknown
    {
        public Unknown()
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 2, 3, -1, -2, -3, 5, 10, 6, 4 };
            Console.WriteLine(solution(arr));
            Console.WriteLine(solution2(""));
            var words = new[]
            {
                "the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog"
            };

            foreach (var evenLetteredWord in Filter(words, 3))
                Console.WriteLine(evenLetteredWord);
        }
        private int solution(int[] A)
        {
            var smallest = 1;
            bool[] arr = new bool[100000];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    arr[A[i]] = true;
                }
            }
            for (int i = 1; i < 100000; i++)
            {
                if (arr[i] == true && smallest == i)
                {
                    smallest++;
                }
            }
            return smallest;

            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
        private string solution2(string S)
        {
            int totalEarned = 0;
            int totalSpent = 0;
            string returnValue = "";

            var arr = S.Split("\n");
            for (int i = 0; i < arr.Length; i++)
            {
                var lineSplit = arr[i].Split(",");
                int result = 0;
                if (int.TryParse(lineSplit[0], out result))
                {
                    if (result > 0)
                    {
                        totalEarned += result;
                    }
                    else
                    {
                        totalSpent += result;
                    }
                }

            }

            if (totalEarned - totalSpent < 0)
            {
                returnValue = "Error 1: Tally is negative";
            }
            else
            {
                returnValue = string.Format("{0}", totalEarned - totalSpent);
            }
            return returnValue;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
        public IEnumerable<string> Filter(IEnumerable<string> words, int length)
        {
            var filtered = words.Where(w => w.Length == length).OrderBy(w => w).Distinct();
            return filtered;
        }
    }
}
