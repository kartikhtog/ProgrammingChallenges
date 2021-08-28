using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms
{
	public class PrintStack
	{
		public class Value
		{
			public Value(int value, int max)
			{
				Val = value;
				Max = max;
			}
			public int Val;
			public int Max;
		}

		public static List<int> getMax(List<string> operations)
		{
			var stack = new Stack<Value>();
			var list = new List<int>();
			for(int i = 0;i < operations.Count; i++)
			{
				//973,243,666
				var operation = operations[i];
				var operationPair = operation.Split(' ');
				var operationType = operationPair.First();
				switch (operationType)
				{
					case "1":
						var newValue =Int32.Parse(operationPair[1]);
						var max = newValue;
						if (stack.Count != 0)
						{
							max = Math.Max(newValue,stack.Peek().Max);

						}
						stack.Push(new Value(newValue,max));
						break;
					case "2":
						if (stack.Count != 0)
						{
							stack.Pop();
						}
						break;
					case "3":
						if (stack.Count != 0)
						{
							Console.WriteLine(stack.Peek().Max);
							list.Add(stack.Peek().Max);
						}
						break;
				}
			}
			return list;
		}
		public static List<int> getMax2(List<string> operations)
		{
			var stack = new Stack<int>();
			var list = new List<int>();
			for (int i = 1; i < operations.Count; i++)
			{
				//973,243,666
				var lastCase = "4";
				int lastMax = 0;
				var operation = operations[i];
				var operationPair = operation.Split(' ');
				var operationType = operationPair.First();
				switch (operationType)
				{
					case "1":
						lastCase = "1";
						stack.Push(Int32.Parse(operationPair[1]));
						break;
					case "2":
						lastCase = "2";
						if (stack.Count != 0)
						{
							stack.Pop();
						}
						break;
					case "3":
						if (lastCase == "3")
						{
							list.Add(lastMax);
						}
						else
						{
							lastMax = stack.Max();
							list.Add(lastMax);
							lastCase = "3";
						}
						break;
				}
			}
			return list;
		}
	}
}
