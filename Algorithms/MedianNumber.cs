using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class MedianNumber
	{
		public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
		{

			public int Compare(TKey x, TKey y)
			{
				int result = x.CompareTo(y);

				if (result == 0)
					return 1; // Handle equality as being greater. Note: this will break Remove(key) or
				else          // IndexOfKey(key) since the comparer never returns 0 to signal key equality
					return result;
			}
		}
		public List<double> runningMedian(List<int> a)
		{ 
			var items = new SortedList<int, int>(new DuplicateKeyComparer<int>());
			var returnItems = new List<Double>();
			double ans;
			foreach (var element in a)
			{
				items.Add(element, element);
				var itemSSS = items.Keys;
				if (items.Count % 2 != 0)
				{
					ans = itemSSS[itemSSS.Count / 2] / 1.0;
				}
				else
				{
					ans = (itemSSS[(itemSSS.Count / 2) - 1] + itemSSS[itemSSS.Count / 2]) / 2.0;
				}
				ans = Math.Round(ans, 1);
				returnItems.Add(ans);
			}
			return returnItems;
		}
	}
}
