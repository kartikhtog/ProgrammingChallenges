using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Amazon
{
    public class SortBoxes
    {
        /*
     * Complete the 'sortBoxes' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY boxList as parameter.
     */

        // alphaNumberic verions
        // old - space lower case string
        // new postive integers
        // sort
        //older... (older then newer)lexicographic
        // new no order change
        public static List<string> sortBoxes(List<string> boxList)
        {
            if (boxList == null || boxList.Count == 0)
            {
                return new List<string>();
            }

            var oldBoxes = new List<string>();
            var newBoxes = new List<String>();
            foreach (var box in boxList)
            {
                var found = false;
                foreach (var boxChar in box)
                {
                    if (found)
                    {
                        // this may not be enough depending on dataset
                        if (boxChar >= '1' && boxChar <= '9')
                        {
                            newBoxes.Add(box);
                        }
                        else
                        {
                            oldBoxes.Add(box);
                        }
                        break;
                    }
                    // find first empty space
                    if (boxChar == ' ')
                    {
                        found = true;
                    }

                }
            }


            oldBoxes = oldBoxes.OrderBy(box =>
            {
                var firstSpace = box.IndexOf(' ');
                return box.Substring(firstSpace + 1, box.Length - firstSpace - 1);
            },
            new CompareString()).ToList();


            oldBoxes.AddRange(newBoxes);
            return oldBoxes;


        }
        private class CompareString : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                for (int i = 0; i < x.Length && i < y.Length; i++)
                {
                    if (x[i] > x[i])
                    {
                        return 1;
                    }
                    else if (x[i] < x[i])
                    {
                        return -1;
                    }
                }
                if (x.Length < y.Length)
                {
                    return 1;
                }
                if (y.Length > x.Length)
                {
                    return -1;
                }
                return 0;
            }
        }
        private bool IsNumberic(char c)
        {
            if (c >= '1' && c <= '9')
            {
                return true;
            }
            return false;
        }

    }
}
