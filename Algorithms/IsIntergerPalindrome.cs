
namespace Algorithms
{
    public class IsIntergerPalindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            var s = x.ToString();
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}