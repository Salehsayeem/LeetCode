namespace Leetcode
{
    public class CheckIfDoubleExists
    {
        public bool CheckIfExist(int[] arr)
        {

            if (arr.Any(i => i != 0 && arr.Contains(i * 2)))
            {
                return true;
            }

            return arr.Count(v => v == 0) > 1;
        }
    }
}
