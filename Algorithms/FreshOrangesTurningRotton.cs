using System.Collections.Generic;

namespace Algorithms
{
    public class FreshOrangesTurningRotton
    {
        private class Orange
        {
            public int Column;
            public int Row;
            public Orange(int column, int row)
            {
                Column = column;
                Row = row;
            }
        }
        // 0 empty, 1 fresh, 2 rotton
        public int OrangesRotting(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0] == null)
            {
                return 0;
            }
            var allRottenOrganes = new List<Orange>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        allRottenOrganes.Add(new Orange(i, j));
                    }
                }
            }
            var minutes = 0;
            var newRottenOranges = allRottenOrganes;
            List<Orange> turningRotton;
            var orangesTurnedRotten = true;
            while (orangesTurnedRotten)
            {
                turningRotton = new List<Orange>();
                foreach (var newRottenOrange in newRottenOranges)
                {
                    var freshNeighbours = FreshOrangeNeighbours(grid, newRottenOrange);
                    foreach (var freshNeighbour in freshNeighbours)
                    {
                        grid[freshNeighbour.Column][freshNeighbour.Row] = 2;
                        turningRotton.Add(freshNeighbour);
                    }

                }
                if (turningRotton.Count == 0)
                {
                    orangesTurnedRotten = false;
                    break;
                }
                allRottenOrganes.AddRange(newRottenOranges);
                newRottenOranges = turningRotton;
                minutes++;
            }

            var innerLoopBroken = false;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        minutes = -1;
                        innerLoopBroken = true;
                        break;
                    }
                }
                if (innerLoopBroken)
                {
                    break;
                }
            }
            return minutes;
        }

        private List<Orange> FreshOrangeNeighbours(int[][] grid, Orange newRottenOrange)
        {
            var freshOranges = new List<Orange>();
            var gridRowLength = grid[0].Length;
            var gridColumnLength = grid.Length;
            //right
            if (newRottenOrange.Column + 1 < gridColumnLength && grid[newRottenOrange.Column + 1][newRottenOrange.Row] == 1)
            {
                freshOranges.Add(new Orange(newRottenOrange.Column + 1, newRottenOrange.Row));
            }
            // down
            if (newRottenOrange.Row + 1 < gridRowLength && grid[newRottenOrange.Column][newRottenOrange.Row + 1] == 1)
            {
                freshOranges.Add(new Orange(newRottenOrange.Column, newRottenOrange.Row + 1));
            }
            // left
            if (newRottenOrange.Row - 1 >= 0 && grid[newRottenOrange.Column][newRottenOrange.Row - 1] == 1)
            {
                freshOranges.Add(new Orange(newRottenOrange.Column, newRottenOrange.Row - 1));
            }
            //up
            if (newRottenOrange.Column - 1 >= 0 && grid[newRottenOrange.Column - 1][newRottenOrange.Row] == 1)
            {
                freshOranges.Add(new Orange(newRottenOrange.Column - 1, newRottenOrange.Row));
            }
            return freshOranges;
        }
    }
}