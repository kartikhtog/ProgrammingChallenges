using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class FindOrderOfItems
    {

        public int[] ArrayRankTransform(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return new int[0];
            }
            if (arr.Length == 1)
            {
                return new int[1] { 1 };
            }
            var array = new int[arr.Length];
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                dictionary.Add(i, arr[i]);
            }
            var sorted = dictionary.OrderBy(x => x.Value).ToList();

            var value = 1;
            var lastItemValue = sorted[0].Value;
            foreach (var item in sorted)
            {
                if (lastItemValue != item.Value)
                {
                    value++;
                }
                array[item.Key] = value;
                lastItemValue = item.Value;
            }

            return array;
        }
    }
}
