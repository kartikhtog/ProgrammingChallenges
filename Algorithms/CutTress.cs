using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Cut tree starting from smallest to largest. Cannot step on 0 values. Find minimum steps.
/// </summary>
public class CutTress
{
    /// <summary>
    /// PositionOfTree
    /// </summary>
    private class Position
    {
        public int x;
        public int y;
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("x:{0},y:{1}", x, y);
        }
    }

    private class Forest
    {
        public Tree[,] Trees;
        public readonly int Width;
        public readonly int Height;

        public Forest(int width, int height)
        {
            Trees = new Tree[width, height];
            this.Width = width;
            this.Height = height;
        }
    }

    private class Tree
    {
        public bool Visited = false;
        public int TreeHeight { get; set; }
        public bool Visitable 
        { 
            get 
            {
                if (TreeHeight == 0)
                {
                    return false;
                }
                return true; 
            } 
        }
        public Tree(int height, bool visited = false)
        {
            this.TreeHeight = height;
            this.Visited = visited;
        }

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="forest"> forest in grid with height of each tree. (0) is unstepable, (1) is cut (1>) is uncut</param>
    /// <returns>The number minumum of steps to cut all trees</returns>
    public int CutOffTree(IList<IList<int>> forest)
    {
        if (forest == null && forest.Count == 0 && forest[0] == null)
        {
            return 0;
        }
        // sort the trees from min to max
        var width = forest.Count;
        var height = forest[0].Count;
        var treesSortedByHeight = new SortedList<int, Position>();
        Forest improvedForest = new Forest(width, height);

        for(int x = 0; x < forest.Count; x++)
        {
            for( int y = 0; y < height; y++)
            {
                improvedForest.Trees[x,y] = new Tree(forest[x][y]);
                if(forest[x][y]>1 && !(x == 0 && y == 0))
                {
                    treesSortedByHeight.Add(forest[x][y],new Position(x, y));
                }
            }
        }
        improvedForest.Trees[0, 0].TreeHeight = 1; // cut the tree you standing on at the start

        var totalSteps = 0;
        var currentTree = new Position(0, 0);
        foreach (var tree in treesSortedByHeight)
        {
            var additionalSteps = FindTree.Find(tree.Value, improvedForest, currentTree);
            if (additionalSteps == -1)
            {
                totalSteps = -1;
                break;
            }
            totalSteps += additionalSteps;
            improvedForest.Trees[tree.Value.x, tree.Value.y].TreeHeight = 1; // cut off tree
            currentTree = tree.Value;
        }
        return totalSteps;
    }

    /// <summary>
    /// Find the minumum steps to a tree
    /// </summary>
    private static class FindTree
    {
        private class Neighbour : Position
        {
            public int StepsToThisNeighbour;
            public Neighbour(int x, int y, int steps = 0)
                : base(x, y)
            {
                StepsToThisNeighbour = steps;
            }
        }
        public static int StepsToNextPosition { get; set; } = 0;

        private static Queue<Position> VisitedNeightbours = new Queue<Position>();

        public static void ResetVisited(Forest forest)
        {
            foreach (var tree in forest.Trees)
            {
                tree.Visited = false;
            }
        }

        public static int Find(Position findPosition, Forest forest, Position BFSPosition)
        {
            StepsToNextPosition = 0;
            ResetVisited(forest);
            forest.Trees[BFSPosition.x, BFSPosition.y].Visited = true;
            FindUsingBFS(findPosition, forest, BFSPosition);
            var result = StepsToNextPosition;
            return result;
        }

        /// <summary>
        /// Finds Tree using BFS
        /// </summary>
        /// <param name="position"></param>
        /// <param name="forest"></param>
        /// <returns>-1 implies unreachable</returns>
        private static void FindUsingBFS(Position findPosition, Forest forest, Position BFSPosition)
        {
            if (findPosition.x == BFSPosition.x && findPosition.y == BFSPosition.y)
            {
                StepsToNextPosition = 0;
                return;
            }
            var neighbours = GetValidNeighbours(BFSPosition, forest);
            if (neighbours.Count() == 0)
            {
                // not found and cannot go anywhere
                StepsToNextPosition = -1;
            }
            foreach (var neighbour in neighbours)
            {
                if (BFSPosition is Neighbour)
                {
                    neighbour.StepsToThisNeighbour = (BFSPosition as Neighbour).StepsToThisNeighbour + 1;
                }
                else
                {
                    neighbour.StepsToThisNeighbour += 1;
                }
                forest.Trees[neighbour.x, neighbour.y].Visited = true;
                VisitedNeightbours.Enqueue(neighbour);
                if (neighbour.x == findPosition.x && neighbour.y == findPosition.y)
                {
                    StepsToNextPosition = neighbour.StepsToThisNeighbour;
                    VisitedNeightbours.Clear();
                    break;
                }
            }
            while (VisitedNeightbours.Count != 0)
            {
                FindUsingBFS(findPosition, forest, VisitedNeightbours.Dequeue());
            }
        }

        private static IList<Neighbour> GetValidNeighbours(Position position, Forest graph)
        {
            int indexX = position.x;
            int indexY = position.y;

            var list = new List<Neighbour>();
            if (indexX - 1 >= 0)
            {
                list.Add(new Neighbour(indexX - 1, indexY));
            }
            if (indexY + 1 < graph.Height)
            {
                list.Add(new Neighbour(indexX, indexY + 1));
            }
            if (indexX + 1 < graph.Width)
            {
                list.Add(new Neighbour(indexX + 1, indexY));
            }
            if (indexY - 1 >= 0)
            {
                list.Add(new Neighbour(indexX, indexY - 1));
            }
            return list.Where(p =>
            {
                if (!graph.Trees[p.x, p.y].Visitable || graph.Trees[p.x, p.y].Visited)
                {
                    return false;
                }
                return true;
            }).ToList();
        }
    }
}