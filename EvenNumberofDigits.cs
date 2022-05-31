namespace Leetcode
{
    public class EvenNumberOfDigits
    {
        //{ 12, 345, 2, 6, 7896 };
        public int FindNumbers(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Floor(Math.Log10(Math.Abs(nums[i])) + 1) % 2 == 0)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
