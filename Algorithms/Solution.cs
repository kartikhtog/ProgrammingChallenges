public class Solution
{
	public int[] PrisonAfterNDays(int[] cells, int n)
	{
		if (n <= 0)
		{
			return cells;
		}
		var repeat = findLengthOfRepeat(cells);
		n = n % repeat;

		for (int i = 1; i <= n; i++)
		{
			var newCells = new int[8];
			for (int j = 1; j <= 6; j++)
			{
				if (cells[j - 1] == 1 && cells[j + 1] == 1 || cells[j - 1] == 0 && cells[j + 1] == 0)
				{
					newCells[j] = 1;
				}
			}
			cells = newCells;
		}
		return cells;
	}
	private int findLengthOfRepeat(int[] originalCells)
	{
		var length = 0;
		var cells = new int[8];
		for (int i = 0; i < 8; i++)
		{
			cells[i] = originalCells[i];
		}
		while (true)
		{
			var newCells = new int[8];
			for (int j = 1; j <= 6; j++)
			{
				if (cells[j - 1] == 1 && cells[j + 1] == 1 || cells[j - 1] == 0 && cells[j + 1] == 0)
				{
					newCells[j] = 1;
				}
			}
			cells = newCells;
			length++;
			for (int k = 0; k < 8; k++)
			{
				if (cells[k] != originalCells[k])
				{
					break;
				}
				if (k == 7)
				{
					return length;
				}
			}
		}
	}
}




//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Algorithms
//{
//    //public class Solution
//    //{
//    //    public enum Direction
//    //    {
//    //        North,
//    //        East,
//    //        South,
//    //        West
//    //    }
//    //    public class Position
//    //    {
//    //        public int x = 0;
//    //        public int y = 0;
//    //        public Direction _Direction = Direction.North;

//    //        public void Go()
//    //        {
//    //            switch(_Direction)
//    //            {
//    //            case Direction.North:
//    //                y++;
//    //                break;
//    //                case Direction.East:
//    //                x++;
//    //                break;
//    //                case Direction.South:
//    //                y--;
//    //                    break;
//    //                case Direction.West:
//    //                x--;
//    //                    break;
//    //            }
//    //        }
//    //        public void TurnLeft()
//    //        {
//    //            if (_Direction > Direction.North)
//    //            {
//    //                _Direction--;
//    //            }
//    //            else
//    //            {
//    //                _Direction = Direction.West;
//    //            }
//    //        }
//    //        public void TurnRight()
//    //        {
//    //            if (_Direction < Direction.West)
//    //            {
//    //                _Direction++;
//    //            }
//    //            else
//    //            {
//    //                _Direction = Direction.North;
//    //            }
//    //        }

//    //    }

//    //    public Position DoInstructions(Position position, string instructions)
//    //    {
//    //        foreach (var instruction in instructions)
//    //        {
//    //            switch (instruction)
//    //            {
//    //                case 'G':
//    //                    position.Go();
//    //                    break;
//    //                case 'L':
//    //                    position.TurnLeft();
//    //                    break;
//    //                case 'R':
//    //                    position.TurnRight();
//    //                    break;
//    //            }
//    //        }
//    //        return position;
//    //    }

//    //    public bool IsRobotBounded(string instructions)
//    //    {
//    //        // need to check at most four times
//    //        // need to check if at the end of the each instructions set we are at the start
//    //        var position = new Position();
//    //        position = DoInstructions(position, instructions);
//    //        if (position.x == 0 && position.y == 0 && position._Direction == Direction.North)
//    //        {
//    //            return true;
//    //        }
//    //        position = DoInstructions(position, instructions);
//    //        if (position.x == 0 && position.y == 0 && position._Direction == Direction.North)
//    //        {
//    //            return true;
//    //        }
//    //        position = DoInstructions(position, instructions);
//    //        if (position.x == 0 && position.y == 0 && position._Direction == Direction.North)
//    //        {
//    //            return true;
//    //        }
//    //        position = DoInstructions(position, instructions);
//    //        if (position.x == 0 && position.y == 0 && position._Direction == Direction.North)
//    //        {
//    //            return true;
//    //        }
//    //        return false;
//    //    }
//    //}

//    public class Solution
//    {
//        bool[] visited;// = bool[isConnected.length];
//        int total = 0;

//        public int FindCircleNum(int[][] isConnected)
//        {
//            visited = new bool[isConnected.Length];
//            for (int i = 0; i < isConnected.Length; i++)
//            {
//                if (!visited[i])
//                {
//                    total++;
//                    Traverse(isConnected, i);

//                }
//            }
//            return total;
//        }
//        public void Traverse(int[][] isConnected, int i)
//        {
//            visited[i] = true;
//            var queue = new Queue<int>();
//            for (int j = 0; j < isConnected.Length; j++)
//            {
//                if (isConnected[i][j] == 1&& !visited[j])
//                {
//                    queue.Enqueue(j);
//                }
//            }
//            while (queue.Count != 0)
//            {
//                Traverse(isConnected, queue.Dequeue());
//            }
//        }
//    }
//}
