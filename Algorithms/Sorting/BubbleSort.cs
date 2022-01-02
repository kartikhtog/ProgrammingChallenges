using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
	public class BubbleSort<T> where T:IComparable
	{
		/// <summary>
		/// Return the element sorted. New list is not created.
		/// </summary>
		/// <param name="elements"></param>
		/// <returns></returns>
		public static T[] Sort(T[] elements)
		{
			var length = elements.Length;
			for(int i = 0; i < length -1; i++)
			{
				var exchangeHappened = false;
				for (int j = 0; j < length - i -1; j++)
				{
					if (elements.IsFirstBigger(j,j+1))
					{
						elements.Swap(j, j + 1);
						exchangeHappened = true;
					}
				}
				if (!exchangeHappened)
				{
					break;
				}
			}
			return elements;
		}
	}
}
