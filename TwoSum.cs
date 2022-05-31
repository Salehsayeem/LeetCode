using System.Collections;

namespace Leetcode
{
    public class TwoSum1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //int n = nums.Length;
            //int[] d = new int[2];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            d[0] = Array.IndexOf(nums, nums[i]);
            //            d[1] = Array.IndexOf(nums, nums[j]);
            //            return d;
            //        }
            //    }
            //}
            //return d;
            var map = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    return new int[] { (int)map[target - nums[i]], i };
                }
                map[nums[i]] = i;
            }
            return new int[0];
        }
    }
}
