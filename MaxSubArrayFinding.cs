namespace Leetcode
{
    public class MaxSubArrayFinding
    {
        public int MaxSubArray(int[] nums)
        {
            int n = nums.Length;
            int maxSum = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                int currSum = 0;
                for (int j = i; j <= n - 1; j++)
                {
                    currSum += nums[j];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                    }
                }
            }

            return maxSum;
        }
    }
}
