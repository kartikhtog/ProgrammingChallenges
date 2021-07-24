using System.Collections.Generic;
using System.Text;
using System.Linq;

public class FindPositionOfWords
{
    

    private List<string> CreatePermuationsOfWords(string[] words)
    {
        var lastWords = new List<List<string>>();//Words<word<string>>()
        var currentWords = new List<List<string>>();//Words<word<string>>()
        lastWords.Add(new List<string> {words[0] });
        for(int w = 1; w < words.Length; w++)
        {
            var word = words[w];
            currentWords = new List<List<string>>();
            foreach(var nonConcatinatedWord in lastWords){
                for(int i = 0; i < nonConcatinatedWord.Count; i++)
                {
                    // create new word
                    // by adding the word before the segment

                    var newWord = nonConcatinatedWord.GetRange(0, i);
                    newWord.Add(word);
                    newWord.AddRange(nonConcatinatedWord.GetRange(i, nonConcatinatedWord.Count - i));
                    currentWords.Add(newWord);
                }
                var lastNewWord = new List<string>(nonConcatinatedWord);
                lastNewWord.Add(word);
                currentWords.Add(lastNewWord);
            }
            lastWords = currentWords;
        }

        if (currentWords.Count == 0)
        {
            currentWords = lastWords;
        }
        var squashedWords = new List<string>();
        foreach(var word in currentWords)
        {
            var sb = new StringBuilder();
            foreach(var segment in word)
            {
                sb.Append(segment);
            }
            squashedWords.Add(sb.ToString());
        }
        return squashedWords.Distinct().ToList();
    }

    public IList<int> FindSubstring(string s, string[] words)
    {
        var list = new List<int>();
        if (words.Length == 0)
        {
            return list;
        }
        var wordsList = CreatePermuationsOfWords(words);

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < wordsList.Count; j++)
            {
                if (s[i]== wordsList[j][0])
                {
                    var match = DoesWordMatch(s,wordsList[j],i);
                    if (match)
                    {
                        list.Add(i);
                    }
                }
            }
        }
        return list;
    }

    private bool DoesWordMatch(string s, string matchWord, int index)
    {
        if (index+matchWord.Length > s.Length)
        {
            return false;
        }
        if (s[index+matchWord.Length/2] != matchWord[matchWord.Length / 2])
        {
            return false;
        }
        for(int i = 1; i < matchWord.Length; i++)
        {
            if (s[index + i] != matchWord[i])
            {
                return false;
            }
        }
        return true;
    }
}
/*
 private class WordsAndMatchedPosition
    {
        public string word;
        public int lettersMatched = 0;
    }
 
        //List<WordsAndMatchedPosition> matchWords = new List<WordsAndMatchedPosition>();//[words.Length];
        //foreach(var newWord in wordsList)// word in words)
        //{
        //    matchWords.Add(new WordsAndMatchedPosition() { word = newWord });
        //}

        //var lengthOfEachWord = matchWords[0].word.Length;

        //for (int i = 0; i < s.Length; i++)
        //{
        //    for (int j = 0; j < matchWords.Count; j++)
        //    {
        //        if (matchWords[j].word[matchWords[j].lettersMatched] != s[i])
        //        {
        //            matchWords[j].lettersMatched = 0;
        //        }
        //        if (matchWords[j].word[matchWords[j].lettersMatched] == s[i])
        //        {
        //            if (matchWords[j].lettersMatched == lengthOfEachWord -1)
        //            {
        //                list.Add(i-matchWords[j].lettersMatched);
        //                matchWords.RemoveAt(j);
        //                j--;
        //            }
        //            else
        //            {
        //                matchWords[j].lettersMatched++;
        //            }
        //        }
        //    }
        //} 
 */

