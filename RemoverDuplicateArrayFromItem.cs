namespace Leetcode
{
    public class RemoverDuplicateArrayFromItem
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int index = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                int currentValue = nums[j];
                if (nums[index] != currentValue)
                {
                    nums[index++ + 1] = currentValue;
                }
            }

            return ++index;
        }
    }
}
