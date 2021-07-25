using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class TelephoneDigitsToCombinations
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrWhiteSpace(digits))
            {
                return new List<string>();
            }

            IList<string> list = new List<string>();
            // take in each digit
            // for each combination already in the add each letter
            var index = 0;
            if (digits.Length > 0)
            {
                list = TelephoneAlphbets(digits[index] - '0');
                index++;
            }
            for (; index < digits.Length; index++)
            {
                IList<string> newList = new List<string>();
                foreach (var newElement in TelephoneAlphbets(digits[index] - '0'))
                {
                    foreach (var existingElement in list)
                    {
                        newList.Add(existingElement + newElement);
                    }
                }
                list = newList;
            }
            return list;
        }
        public IList<string> TelephoneAlphbets(int i)
        {
            var result = new List<string>();
            switch (i)
            {
                case 2:
                    result = new List<string>() { "a", "b", "c" };
                    break;
                case 3:
                    result = new List<string>() { "d", "e", "f" };
                    break;
                case 4:
                    result = new List<string>() { "g", "h", "i" };
                    break;
                case 5:
                    result = new List<string>() { "j", "k", "l" };
                    break;
                case 6:
                    result = new List<string>() { "m", "n", "o" };
                    break;
                case 7:
                    result = new List<string>() { "p", "q", "r", "s" };
                    break;
                case 8:
                    result = new List<string>() { "t", "u", "v" };
                    break;
                case 9:
                    result = new List<string>() { "w", "x", "y", "z" };
                    break;
            }
            return result;
        }
    }
}
