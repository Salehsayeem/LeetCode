namespace Leetcode
{
    public class DuplicateZeroCalculation
    {
        public void DuplicateZeros(int[] arr)
        {
            List<int> newArray = new List<int>();
            foreach (var t in arr)
            {
                if (t == 0)
                {
                    newArray.Add(0);
                    newArray.Add(0);
                }
                else
                {
                    newArray.Add(t);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = newArray[i];
            }
            newArray.ToArray();
        }
    }
}
