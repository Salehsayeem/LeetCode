namespace Leetcode
{
    public class Isomorphic
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length == 0 || t.Length == 0 || s.Length != t.Length) return false;
            bool result = true;
            Dictionary<char, char> seen1 = new Dictionary<char, char>();
            Dictionary<char, char> seen2 = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char letter1 = s[i];
                char letter2 = t[i];

                if (seen1.ContainsKey(letter1))
                {
                    if (seen1[letter1] != letter2)
                    {
                        return false;
                    }
                }
                if (seen2.ContainsKey(letter2))
                {
                    if (seen2[letter2] != letter1)
                    {
                        return false;
                    }
                }
                seen1[letter1] = letter2;
                seen2[letter2] = letter1;
            }
            return result;
        }
    }
}
