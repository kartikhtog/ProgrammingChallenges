public class LongestCommonPrefixAmoungStrings
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null && strs.Length == 0)
        {
            return "";
        }
        var prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            for (int j = 0; j < prefix.Length; j++)
            {
                if (strs[i].Length - 1 < j || prefix[j]!=strs[i][j])
                {
                    prefix = strs[i].Substring(0, j);
                    break;
                }
            }
        }
        return prefix;
    }
}
