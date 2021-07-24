using System;

public class HowMuchWaterCanBeTrappedInside
{
    public int Trap(int[] height)
    {
        // height of next block
        //
        var totalArea = 0;
        var areaOfLand = 0;

        var startIndex = 0;
        var endIndex = height.Length - 1;
        // find the index of the last largest number
        //var max = Math.Max(height);

        while (startIndex < endIndex)
        {
            // terverse from front to back
            if (height[startIndex + 1] > height[startIndex])
            {

            }
            // terverse from back to front
        }
        throw new NotImplementedException();
    }
    private void FindIndexOfLastLargestNumber(int[] nums)
    {

    }
}

















