namespace Algorithms
{
    public class RotateByK
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length <= 1 || k == 0 || nums.Length == k)
            {
                return;
            }
            k = k % nums.Length;
            var lastIndex = 0;
            var lastSavedValue = nums[0];
            var repeatIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var indexMovingTo = (lastIndex + k) % nums.Length;
                //Console.WriteLine(string.Format("Moving {0} from {1} to {2}", lastSavedValue, lastIndex, indexMovingTo));
                var temp = nums[indexMovingTo];
                nums[indexMovingTo] = lastSavedValue;
                lastSavedValue = temp;
                //Console.WriteLine(string.Format("Saving {0} for next time",lastSavedValue));
                lastIndex = indexMovingTo;
                if (indexMovingTo == repeatIndex)
                {
                    // back to the same index without finishing possibly .. make it move to next index
                    lastIndex = indexMovingTo + 1;
                    repeatIndex++;
                    lastSavedValue = nums[lastIndex];
                }
            }
        }

        // 1,2,3,4,5,6,7,8,9

        // 3
        // 1,4,5,1
        // 1,5,9,4,8,3,7,2,6,1
        // 1,3,5,7,9,2,4,6,8,1
        // 1,6,2,7,3,8,4,9,5,1
        // 

        public void Rotate2(int[] nums, int k)
        {
            if (nums == null)
            {
                return;
            }
            var nums2 = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums2[i] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[(i + k) % nums.Length] = nums2[i];
            }
        }
    }
}
















