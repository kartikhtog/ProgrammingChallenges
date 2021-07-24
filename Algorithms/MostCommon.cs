using System;
using System.Collections.Generic;
using System.Linq;

public class MostCommon
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        
        var result = "";
        var charsToRemove = new string[] { "@", ",", ".", ";", "'","!" };
        foreach (var c in charsToRemove)
        {
            paragraph = paragraph.Replace(c, " ");
        }
        var words = paragraph.Split(' ').Where(w=>w!="").Select(w=>w.ToLower());
        var dictionary = new Dictionary<string, int>();
        foreach(var word in words)
        {
            var isWordBanned = false;
            foreach(var bannedWord in banned)
            {
                
                if (string.Compare(word,bannedWord,StringComparison.OrdinalIgnoreCase) == 0)
                {
                    isWordBanned = true;
                }
            }
            if (!isWordBanned)
            {
                int repeat;
                if (dictionary.TryGetValue(word, out repeat))
                {
                    var newRepeat = repeat;
                    dictionary.Remove(word);
                    dictionary.Add(word, newRepeat + 1);
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }
        }
        result = dictionary.OrderByDescending(w => w.Value).FirstOrDefault().Key;
        return result;
    }
}
