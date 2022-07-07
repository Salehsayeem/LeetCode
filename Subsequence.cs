namespace Leetcode
{
    public class Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int n = s.Length;
            int j = 0;
            for (int i = 0; i < t.Length && j < n; i++)
            {
                if (s[j] == t[i])
                {
                    j++;
                }
            }

            return (j == n);
        }
    }
}
