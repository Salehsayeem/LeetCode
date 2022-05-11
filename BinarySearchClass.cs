namespace BinarySearch
{
    public class BinarySearchClass
    {
        public int Search(int[] nums, int target)
        {
            int countArray = nums.Length;
            int low = 0;
            int high = countArray - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
