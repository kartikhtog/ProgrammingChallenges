using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{

	public class MinHeap
	{
		private List<int> MHeap;
		private int Size = 0;
		private readonly bool printToConsole;

		public bool StoreValue { get; private set; }
		public List<int> Values { get; private set; } = new List<int>();

		public MinHeap(List<string> args, bool storeValue = false, bool printToConsole = true)
		{
			MHeap = new List<int>(args.Count + 1);
			MHeap.Add(int.MinValue);
			StoreValue = storeValue;
			this.printToConsole = printToConsole;
			Qheap(args);
		}
		private void Qheap(List<string> args)
		{
			foreach(var arg in args)
			{
				switch (arg[0])
				{
					case '1':
						AddElelemnt(int.Parse(arg.Split(' ')[1]));
							break;
					case '2':
						DeleteElement(int.Parse(arg.Split(' ')[1]));
						break;
					case '3':
						PrintMin();
						break;
				}
			}
		}

		private void PrintMin()
		{
			//Console.WriteLine("Printing Element");
			if (Size != 0)
			{
				if (StoreValue)
				{
					Values.Add(MHeap[1]);
				}
				if (printToConsole)
				{
					Console.WriteLine(MHeap[1]);
				}
			} 
		}

		private void DeleteElement(int v)
		{
			//Console.WriteLine("Deleting Element: " + v);
			var indexToDelete = MHeap.FindIndex(x => x == v);
			if (indexToDelete == -1)
			{
				return;
			}
			if(indexToDelete == Size)
			{
				Size--;
				return;
			}
			MHeap[indexToDelete] = MHeap[Size--];
			Heapify(indexToDelete);

		}

		private void Heapify(int indexToDelete)
		{
			if (!IsLeaf(indexToDelete))
			{
				if (MHeap[indexToDelete] > MHeap[LChild(indexToDelete)] || MHeap[indexToDelete] > MHeap[RChild(indexToDelete)])
				{
					if (MHeap[RChild(indexToDelete)] > MHeap[LChild(indexToDelete)])
					{
						Swap(indexToDelete, LChild(indexToDelete));
						Heapify(LChild(indexToDelete));
					}
					else
					{
						Swap(indexToDelete, RChild(indexToDelete));
						Heapify(RChild(indexToDelete));
					}
				}
			}
		}

		private void Swap(int index1, int index2)
		{
			var temp = MHeap[index1];
			MHeap[index1] = MHeap[index2];
			MHeap[index2] = temp;
		}

		private bool IsLeaf(int index)
		{
			if (index > Size/2 && index <= Size)
			{
				return true;
			}
			return false;
		}

		private int LChild(int parentIndex)
		{
			return parentIndex * 2;
		}
		private int RChild(int parentIndex)
		{
			return (parentIndex * 2) +1;
		}
		private int Parent(int childIndex)
		{
			return childIndex / 2;
		}
		private void AddElelemnt(int v)
		{
			//Console.WriteLine("Adding Element: " +  v);
			MHeap.Add(int.MinValue);
			MHeap[++Size] = v;
			var childIndex = Size;
			while (Parent(childIndex) >= 1 && MHeap[childIndex] < MHeap[Parent(childIndex)])
			{
				Swap(childIndex, Parent(childIndex));
				childIndex = Parent(childIndex);
			}
		}
	}

}
