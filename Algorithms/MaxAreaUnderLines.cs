using System;

namespace Algorithms
{
    public class MaxAreaUnderLines
    {
        public int MaxArea(int[] height)
        {
            var maxArea = int.MinValue;
            var startIndex = 0;
            var endIndex = height.Length - 1;
            while (startIndex < endIndex)
            {
                var area = Math.Min(height[startIndex], height[endIndex]) * (endIndex - startIndex);
                if (area > maxArea)
                {
                    maxArea = area;
                }
                if (height[startIndex] > height[endIndex])
                {
                    endIndex--;
                }
                else
                {
                    startIndex++;
                }
            }
            return maxArea;
        }
    }
}
    //Console.WriteLine(string.Format("the height is {0} and distance is {1}",Math.Min(height[j],height[i]),j-i));