namespace Leetcode
{
    public class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            int sumRight = 0, sumLeft = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sumRight += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                sumRight -= nums[i];
                if (sumRight == sumLeft) return i;
                sumLeft += nums[i];
            }
            return -1;
        }
    }
}
