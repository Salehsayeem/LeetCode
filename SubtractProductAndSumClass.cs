namespace Leetcode
{
    public class SubtractProductAndSumClass
    {
        //Product of digits = 2 * 3 * 4 = 24 
        //Sum of digits = 2 + 3 + 4 = 9 
        //Result = 24 - 9 = 15
        public int SubtractProductAndSum(int n)
        {
            int pr = 1, sum = 0;
            while (n != 0)
            {
                int digit = n % 10;
                sum += digit;
                pr *= digit;
                n /= 10;
            }

            return pr - sum;
        }
    }
}
