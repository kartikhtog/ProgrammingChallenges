using System.Collections.Generic;

namespace Algorithms
{
    public class MovingAverage
    {
        Queue<int> queue = new Queue<int>();
        int sum = 0;
        int Size = 0;
        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            Size = size;
        }

        public double Next(int val)
        {
            if (queue.Count >= Size)
            {
                sum -= queue.Dequeue();
            }
            queue.Enqueue(val);
            sum += val;
            return ((double)sum) / ((double)queue.Count);
        }
    }
}