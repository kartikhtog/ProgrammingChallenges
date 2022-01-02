using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	// A search Algorithm?
	public class KnightlOnAChessboardClass
	{
		/*
 * Complete the 'knightlOnAChessboard' function below.
 *
 * The function is expected to return a 2D_INTEGER_ARRAY.
 * The function accepts INTEGER n as parameter.
 */

		public static List<List<int>> knightlOnAChessboard(int n)
		{
			var list = new List<List<int>>();
			for (int a = 1; a < n; a++)
			{
				var aMoves = new List<int>();
				for (int b = 1; b < n; b++)
				{
					var moves = ShortedPath(a, b, n);
					aMoves.Add(moves);
				}
				list.Add(aMoves);
			}
			return list;
		}

		private class Position
		{
			public int a;
			public int b;
			public int MovesToGetHere = 0;
			public Position(int a, int b, int movesToGetHere = 0)
			{
				this.a = a;
				this.b = b;
				MovesToGetHere = movesToGetHere;
			}
		}
		private static int ShortedPath(int stepSize, int otherStepSize,int boardSize)
		{
			// go from 0,0 to n-1,n-1
			// bfs
			var visited = new bool[boardSize, boardSize];
			var finalPosition = boardSize - 1;
			Queue<Position> unVisted = new Queue<Position>();
			var found = -1;
			unVisted.Enqueue(new Position(0, 0));
			while (unVisted.Count != 0)
			{
				var current = unVisted.Dequeue();
				var a = current.a;
				var b = current.b;
				if (!visited[current.a, current.b])
				{
					visited[a, b] = true;
					if (a == finalPosition && b == finalPosition)
					{
						found = current.MovesToGetHere;
						break;
					}
					else
					{
						var movesToGetToNeigbour = current.MovesToGetHere + 1;
						// add neighbours to queue
						{
							if (a + stepSize < boardSize && b + otherStepSize < boardSize)
							{
								unVisted.Enqueue(new Position(a + stepSize, b + otherStepSize, movesToGetToNeigbour));
							}
							if (a + stepSize < boardSize && b - otherStepSize >= 0)
							{
								unVisted.Enqueue(new Position(a + stepSize, b - otherStepSize, movesToGetToNeigbour));
							}

							if (a - stepSize >= 0 && b + otherStepSize < boardSize)
							{
								unVisted.Enqueue(new Position(a - stepSize, b + otherStepSize, movesToGetToNeigbour));
							}
							if (a - stepSize >= 0 && b - otherStepSize >= 0)
							{
								unVisted.Enqueue(new Position(a - stepSize, b - otherStepSize, movesToGetToNeigbour));
							}

							if (a + otherStepSize < boardSize && b + stepSize < boardSize)
							{
								unVisted.Enqueue(new Position(a + otherStepSize, b + stepSize, movesToGetToNeigbour));
							}
							if (a + otherStepSize < boardSize && b - stepSize >= 0)
							{
								unVisted.Enqueue(new Position(a + otherStepSize, b - stepSize, movesToGetToNeigbour));
							}

							if (a - otherStepSize >= 0 && b + stepSize < boardSize)
							{
								unVisted.Enqueue(new Position(a - otherStepSize, b + stepSize, movesToGetToNeigbour));
							}
							if (a - otherStepSize >= 0 && b - stepSize >= 0)
							{
								unVisted.Enqueue(new Position(a - otherStepSize, b - stepSize, movesToGetToNeigbour));
							}
						}

					}
				}
			}
			return found;
		}
	}
}
