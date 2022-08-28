using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Permutation
    {
        public int[] BuildArray(int[] nums)
        {
            var ans = nums.Select(a => nums[a]).ToArray();
            return ans;
        }
    }
}
