using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
namespace AlgorithmsTests
{

	public static class ListExtentionMethods
	{
		public static List<T> Addd<T>(this List<T> list, T item)
		{
			list.Add(item);
			return list;
		}
	}
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="W">input type</typeparam>
	/// <typeparam name="T">output type</typeparam>
	public class MeasureTimeOfFunctions<W, T>
	{
		List<List<TimeSpan>> timeSpansOfSamples = new List<List<TimeSpan>>();

		public void PrintTimes()
		{
			foreach (var timeSpans in timeSpansOfSamples)
			{
				foreach (var timeSpan in timeSpans)
				{
					Console.Write(timeSpan + " ");
				}
				Console.WriteLine();
			}
		}
		public string GetTimeInCSV(List<int> sizes = null) 
		{
			var sb = new StringBuilder();
			int i = 0;
			foreach(var timeSpans in timeSpansOfSamples)
			{
				if (sizes != null)
				{
					sb.Append(sizes[i]);
					sb.Append(",");
					i++;
				}
				foreach(var timeSpan in timeSpans)
				{
					sb.Append(timeSpan.TotalMilliseconds);
					sb.Append(",");
				}
				sb.Append("\n");
			}
			return sb.ToString();
		}
		public void Measure(W input, T output, params Func<W, T>[] measureFunctions)
		{
			var timeSpans = new List<TimeSpan>();
			var stopWatch = new Stopwatch();
			foreach (var function in measureFunctions)
			{
				stopWatch.Start();
				var result = function(input);
				stopWatch.Stop();
				timeSpans.Add(stopWatch.Elapsed);
				//Console.WriteLine(string.Format("Time Elaped on function is {0}", stopWatch.Elapsed));
				if (output != null)
				{
					if (output.GetType().IsPrimitive || output.GetType() == typeof(string))
					{
						Assert.AreEqual(output, result);
					}
				}
				if (output != null && output is IEnumerable<T>)
				{
					if (!(input is IEnumerable<T>))
					{
						Assert.Fail();
					}
					var res = result as IEnumerable<T>;
					var outputs = output as IEnumerable<T>;
					Assert.AreEqual(outputs.Count(), res.Count());
					if (res.Count() > 0)
					{
						Assert.AreEqual(true, outputs.SequenceEqual(res));
					}
				}
				stopWatch.Reset();
			}
			timeSpansOfSamples.Add(timeSpans);

		}
		//public static void Measure(W input, IEnumerable<T> output, params Func<W, T>[] measureFunctions)
		//{
		//	var stopWatch = new Stopwatch();
		//	foreach (var function in measureFunctions)
		//	{
		//		stopWatch.Start();
		//		var result = function(input);
		//		stopWatch.Stop();
		//		Console.WriteLine(string.Format("Time Elaped on function is {0}", stopWatch.Elapsed));
		//		if (result is IEnumerable<T>)
		//		{
		//			var res = result as IEnumerable<T>;
		//			Assert.AreEqual(output.Count(), res.Count());
		//			if (res.Count() > 0)
		//			{
		//				Assert.AreEqual(true, output.SequenceEqual(res));
		//			}
		//		}
		//		stopWatch.Reset();

		//	}
		//}	

		//public static void Measure(W input, params (Func<W, T> measureFunctions, string funcName)[] funtionsAndNames)
		//{

		//}

	}
}
