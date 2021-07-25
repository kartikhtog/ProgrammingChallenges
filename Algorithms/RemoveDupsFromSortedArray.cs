
namespace Algorithms
{
    public class RemoveDupsFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            var skip = 0;
            var index = 0;
            while (index < nums.Length - 1)
            {
                index++;
                if (nums[index - skip - 1] == nums[index])
                {
                    skip++;
                }
                nums[index - skip] = nums[index];
            }
            return nums.Length - skip;
        }
    }

}












