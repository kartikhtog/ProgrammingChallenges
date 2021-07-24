using System.Collections.Generic;
using System.Linq;

public class Synonyms
{
    private class CompareStrings : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            for(int i = 0; i < x.Length && i < y.Length; i++)
            {
                if (x[i] < y[i])
                {
                    return -1;
                }
                else if (x[i] > y[i])
                {
                    return 1;
                }
            }
            if (x.Length == y.Length)
            {
                return 0;
            }
            if (x.Length > y.Length)
            {
                return 1;
            }
            return -1;
        }
    }

    public IList<string> GenerateSentences(IList<IList<string>> synonyms, string text)
    {
        var sentences = new List<string>();
        
        sentences.Add(text);

        foreach(var synonymWords in synonyms)
        {
            sentences.AddRange(MakeNewSentencesFromSynonyms(sentences, synonymWords));
        }

        //var hey = from a in sentences
        //            orderby a
        //            select a;
        //sentences = hey.ToList();

        return sentences.OrderBy(x => x,new CompareStrings()).ToList();
    }
    
    private List<string> MakeNewSentencesFromSynonyms(List<string> sentences, IList<string> synonymWords)
    {
        var newSentences = new List<string>();
        foreach (var synonym in synonymWords)
        {
            foreach (var sentence in sentences)
            {
                var indexes = getIndexesOfWords(sentence);
                foreach (var index in indexes)
                {
                    if (synonym.Length + index <= sentence.Length && sentence.Substring(index, synonym.Length) == synonym)
                    {
                        foreach(var newWord in synonymWords)
                        {
                            if (newWord != synonym)
                            {
                                newSentences.Add(sentence.Substring(0, index) + newWord + sentence.Substring(index + synonym.Length));
                            }
                        }
                    }
                }
            }
        }
        return newSentences;
    }

    private List<int> getIndexesOfWords(string text)
    {
        var list = new List<int>();
        if (text[0] != ' ')
        {
            list.Add(0);
        }
        for(int i = 0;i < text.Length -1; i++)
        {
            if (text[i] == ' ' && i < text.Length -1)
            {
                list.Add(i + 1);
            }
        }
        return list;
    }
}
    /*var betterSynonyms = new List<List<string>>();
    for(int i = 0; i < synonyms.Count; i++)
    {
        var currentSynonyms = new List<String>();
        currentSynonyms.Add(synonyms[i][0]);
        currentSynonyms.Add(synonyms[i][1]);
        for(int j = i + 1; j < synonyms.Count; j++)
        {
            var currentSynonymsLength = currentSynonyms.Count;
            for(int k = 0; k < currentSynonymsLength; k++)
            {
                if (currentSynonyms[k] == synonyms[j][0])
                {
                    currentSynonyms.Add(synonyms[j][1]);
                    synonyms.RemoveAt(j);
                    j--;

                }
                else if (currentSynonyms[k] == synonyms[j][1])
                {
                    currentSynonyms.Add(synonyms[j][0]);
                    synonyms.RemoveAt(j);
                    j--;

                }
            }
        }
        betterSynonyms.Add(currentSynonyms);
    }*/
    /*                            newSentences.AddRange(sentences.SelectMany(x => 
                            {
                                var newList = new List<string>();
                                foreach (var replaceWord in synonymWords)
                                {
                                    newList.Add();
                                }
                                return newList;
                            }).ToList());
*/