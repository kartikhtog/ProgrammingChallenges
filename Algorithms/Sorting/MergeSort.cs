using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
	public class MergeSort<T> where T : IComparable
	{
		/// <summary>
		/// Return the element sorted. New List is created.
		/// </summary>
		/// <param name="elements"></param>
		/// <returns></returns>
		public static T[] Sort(T[] elements)
		{
			elements = Sort(elements, 0, elements.Length - 1);
			return elements;
		}

		/// <summary>
		/// Return the element sorted. New list is created.
		/// </summary>
		/// <param name="elements"></param>
		/// <returns></returns>
		private static T[] Sort(T[] elements,int startIndex, int endIndex)
		{
			if (startIndex < endIndex)
			{
				var midIndex = ((endIndex - startIndex + 1) / 2) + startIndex -1;
				var firstArray = Sort(elements, startIndex, midIndex);
				var secondArray = Sort(elements, midIndex + 1, endIndex);
				return Merge(firstArray, secondArray);
			}
			return new T[]{elements[startIndex] };
		}

		private static T[] Merge(T[] firstArray, T[] secondArray)
		{
			var indexFirstArray = 0;
			var indexSecondArray = 0;
			var firstArrayLength = firstArray.Length;
			var secondArrayLength = secondArray.Length;
			T[] arr = new T[firstArrayLength + secondArrayLength];
			var newArrayIndex = 0;
			while(indexFirstArray < firstArrayLength && indexSecondArray < secondArrayLength)
			{
				if(firstArray[indexFirstArray].CompareTo(secondArray[indexSecondArray])<0)
				{
					arr[newArrayIndex++] = firstArray[indexFirstArray++];
				}
				else
				{
					arr[newArrayIndex++] = secondArray[indexSecondArray++];
				}
			}
			// finish off loading the rest
			while(indexFirstArray < firstArrayLength)
			{
				arr[newArrayIndex++] = firstArray[indexFirstArray++];
			}
			// finish off loading the rest
			while (indexSecondArray < secondArrayLength)
			{
				arr[newArrayIndex++] = secondArray[indexSecondArray++];
			}
			return arr;
		}
	}
}
