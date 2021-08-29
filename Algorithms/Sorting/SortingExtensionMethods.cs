using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
	public static class SortingExtensionMethods
	{
		public static void Swap<T>(this T[] elements, int index1,int index2)
		{
			var temp = elements[index1];
			elements[index1] = elements[index2];
			elements[index2] = temp;
		}
	}
}
