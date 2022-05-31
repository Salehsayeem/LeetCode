namespace Leetcode
{
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int result = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == 0 || nums[i] == 1)
                {
                    if (nums[i] == 0)
                    {
                        count = 0;
                    }
                    else
                    {
                        count++;
                        result = Math.Max(result, count);
                    }
                }

            }
            return result;
        }
    }
}
