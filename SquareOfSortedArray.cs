namespace BinarySearch
{
    public class SquareOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            var squaredArray = nums.Select(x => x * x).ToArray();
            var desc = squaredArray.OrderBy(i => i).ToArray();
            return desc;
        }
    }
}
