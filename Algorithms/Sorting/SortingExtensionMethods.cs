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
		public static bool IsFirstBigger<T>(this T[] elements, int index1, int index2) where T : IComparable
		{
			return (elements[index1].CompareTo(elements[index2]) > 0);
		}		
		public static bool IsSecondBigger<T>(this T[] elements, int index1, int index2) where T : IComparable
		{
			return (elements[index1].CompareTo(elements[index2]) < 0);
		}
		public static bool IsMoreThanValue<T>(this T element, T value) where T : IComparable
		{
			return (element.CompareTo(value) > 0);
		}
		public static bool IsLessThanValue<T>(this T element, T value) where T : IComparable
		{
			return (element.CompareTo(value) < 0);
		}	
		

		public static Int16 DigitAt(this int number)
		{
			return 0;
		}
	}

	public static class ListExtensionMethods
	{
		public static void AddItems<T>(this List<T> list, params T[] items)
		{
			foreach(var item in items)
			{
				list.Add(item);
			}
		}
	}

	public class HelperMethods<T> where T: IComparable
	{
		public static T Max<T>(params T[] elements) where T : IComparable
		{
			var max = elements[0];
			foreach (var element in elements)
			{
				if (element.CompareTo(max) > 0)
				{
					max = element;
				}
			}
			return max;
		}
	}
}
