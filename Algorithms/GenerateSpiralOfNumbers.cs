public class GenerateSpiralOfNumbers
{
    public int[][] GenerateMatrix(int n)
    {
        var doubleArray = new int[n][];
        for(int i = 0; i < n; i++)
        {
            doubleArray[i] = new int[n];
        }
        Direction goingDirection = Direction.Right;//right //1 down // 2 left // 3 up
        var horizontalIndex = -1;
        var verticalIndex = 0;

        var minRowCompleted = -1;
        var maxRowCompleted = n;
        var minColumnCompleted = -1;
        var maxColumnCompleted = n;

        for (int i = 0; i < n * n; i++)
        {
            if (goingDirection == Direction.Right)
            {
                horizontalIndex++;
                if (horizontalIndex == maxColumnCompleted -1)
                {
                    minRowCompleted++;
                    goingDirection = Direction.Down;
                }
            }
            else if (goingDirection == Direction.Down)
            {
                verticalIndex++;
                if (verticalIndex == maxRowCompleted -1)
                {
                    maxColumnCompleted--;
                    goingDirection = Direction.Left;
                }
            }
            else if (goingDirection == Direction.Left)
            {
                horizontalIndex--;
                if (horizontalIndex == minColumnCompleted +1)
                {
                    maxRowCompleted--;
                    goingDirection = Direction.Up;
                }
            }
            else if (goingDirection == Direction.Up)
            {
                verticalIndex--;
                if (verticalIndex == minRowCompleted +1)
                {
                    minColumnCompleted++;
                    goingDirection = Direction.Right;
                }
            }
            doubleArray[verticalIndex][horizontalIndex] = i + 1;
        }
        return doubleArray;
    }
    enum Direction
    {
        Right,
        Down,
        Left,
        Up
    }
}
