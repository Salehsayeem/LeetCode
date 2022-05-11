namespace BinarySearch
{
    public class DuplicateArray
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length != nums.Distinct().Count()) return true;
            return false;
        }
    }
}
