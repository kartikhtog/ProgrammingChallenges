using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
	class RearrangeBarcodes
	{
        public void Test()
		{
            var s = "dsf";
            var index = s.IndexOf('+');
            var hhk = new HashSet<string>();
		}
		public int[] Rearrage(int[] barcodes)
		{
            var dictionary = new Dictionary<int, int>();

            foreach (var barcode in barcodes)
            {
                if (!dictionary.ContainsKey(barcode))
                {
                    dictionary.Add(barcode, 1);
                }
                else
                {
                    dictionary[barcode]++;
                }
            }
            var something = dictionary.OrderByDescending(x => x.Value); //.Select(x => (x.Key, x.Value)).ToArray();//.ToDictionary(x => x.Key, x => x.Value);
			var result = new int[barcodes.Length];
            var index = 0;
            foreach(var item in something)
			{
                var count = 0;
                while(count < item.Value)
				{
                    result[index] = item.Key;
                    index += 2;
                    count++;
                    if (index >= result.Length)
					{
                        index = 1;
					}
				}
			}


            return result;
        }

	}
}
//foreach (var item in dictionaryOfItems)
//{
//	if (dictionary.ContainsKey(item.Key))
//	{
//		result[index] = item.Key;
//		dictionary[item.Key]--;
//		if (dictionary[item.Key] <= 0)
//		{
//			dictionary.Remove(item.Key);
//			itemsToRemove.Add(item.Key);
//		}
//		index++;
//	}

/*
 		
				}
                foreach (var item in itemsToRemove)
                {
                    dictionaryOfItems.Remove(item);
                }
                itemsToRemove = new List<int>();*/