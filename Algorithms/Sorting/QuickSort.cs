using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
	public class QuickSort<T> where T : IComparable
	{
		/// <summary>
		/// Return the element sorted. New list is not created.
		/// </summary>
		/// <param name="elements"></param>
		/// <returns></returns>
		public static T[] Sort(T[] elements)
		{
			var low = 0;
			var high = elements.Length - 1;
			var pi = Partition(elements, low, high);
			Sort(elements, low, pi - 1);
			Sort(elements, pi + 1, high);
			return elements;
		}
		/// <summary>
		/// Return the element sorted. New list is not created.
		/// </summary>
		/// <param name="elements"></param>
		/// <returns></returns>
		private static T[] Sort(T[] elements, int low, int high)
		{
			if (low < high)
			{
				var pi = Partition(elements, low, high);
				Sort(elements, low, pi - 1);
				Sort(elements, pi + 1, high);
			}
			return elements;
		}

		private static int Partition(T[] elements, int low, int high)
		{
			// high is your pivot now.
			var pivot = elements[high];

			var highElementIndex = low;
			for(var index = low; index < high; index++)
			{
				if (elements[index].IsLessThanValue(pivot))
				{
					elements.Swap(index, highElementIndex);
					highElementIndex++;
				}
			}
			elements.Swap(high, highElementIndex);
			return highElementIndex;
		}
	}
}
