namespace Leetcode
{
    public class IntersectionOfTwoArray
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var list = nums1.ToList();
            var result = new List<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (list.Contains(nums2[i])) // if we find identical number, so...
                {
                    result.Add(nums2[i]); // add this one to result and
                    list.Remove(nums2[i]); // remove from list 
                }
            }

            return result.ToArray();
        }
    }
}
