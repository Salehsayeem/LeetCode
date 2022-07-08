namespace Leetcode
{
    public class NumberOf1Bit
    {
        public int HammingWeight(uint n)
        {
            int ans = 0;
            for (int i = 0; i < 32; i++)
            {
                ans = (int)(ans + (n & 1));
                n = n >> 1;
            }
            return ans;
        }
    }
}
