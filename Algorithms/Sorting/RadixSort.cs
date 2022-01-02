using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
	public class RadixSort
	{
		/// <summary>
		/// Return the element sorted. New list is not created.
		/// </summary>
		/// <param name="elements"></param>
		/// <returns></returns>
		public static int[] Sort(int[] elements)
		{
			var baseLength = 1;
			var lengthOfHeightElement = 10;
			var LargestElement = int.MinValue;
			foreach(var element in elements)
			{
				if (element > LargestElement)
				{
					LargestElement = element;
				}
			}
			
			var length = elements.Length;

			return elements;
		}
	}
}
