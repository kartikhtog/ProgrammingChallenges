using System.Text;

public class LoggestPalindrome
{
    public string PalandromeAtIndex(string s, int index, bool aboveIndex = false)
    {
        var sb = new StringBuilder();
        var beginIndex = index - 1;
        if (!aboveIndex)
        {
            sb.Append(s[index]);
        }
        else
        {
            beginIndex = index;
        }
        var endIndex = index + 1;
        while (s.Length - 1 >= endIndex && beginIndex >= 0 && s[beginIndex] == s[endIndex])
        {
            sb.Insert(0, s[beginIndex]).Append(s[endIndex]);
            beginIndex--;
            endIndex++;
        }
        return sb.ToString();
    }   
 
    public string LongestPalindrome(string s)
    {
        var loggestPalandrome = "";
        var loggestPalLen = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            var currentPal = PalandromeAtIndex(s,i);
            var currentPalAbove = PalandromeAtIndex(s,i, true);
            if (currentPal.Length > loggestPalLen)
            {
                loggestPalLen = currentPal.Length;
                loggestPalandrome = currentPal;
            }   
            if (currentPal.Length > loggestPalLen)
            {
                loggestPalLen = currentPal.Length;
                loggestPalandrome = currentPal;
            }
        }
        return loggestPalandrome;
    }
}
