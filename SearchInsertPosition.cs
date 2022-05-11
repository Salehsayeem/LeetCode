namespace BinarySearch
{
    //https://leetcode.com/problems/search-insert-position/
    public class SearchInsertPosition
    {
        //    int[] num = { 1, 3, 5, 6 };
        //    const int target = 7;
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = (right + left) / 2;

            while (left <= right)
            {
                mid = (right + left) / 2;

                // Return the index if target is equal.
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;   // Shift to Right part of the Array to search for the element. 
                    mid = mid + 1;    // Update mid for the last iteration sceanrio and for storing the index. 
                }
                else
                {
                    right = mid - 1;  // Shift to Left part of the Array to search for the element. 

                    // Update mid for the last iteration sceanrio and for storing the index.
                    // Take care of the scenario where the last element need to be kept (e.g. [3,5,7,9,10] 8)
                    mid = nums[mid] < target ? mid - 1 : mid;
                }
            }
            return mid;
        }
    }
}
