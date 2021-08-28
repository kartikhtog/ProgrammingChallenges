using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class SubstringWithConcatenationOfAllWords
	{
		public IList<int> FindSubstring(string s, string[] words)
		{
			var list = new List<int>();
			if (string.IsNullOrEmpty(s))
			{
				return list;
			}
			if (words == null || words.Length == 0)
			{
				return list;
			}
			var expectedWords = new Dictionary<string, int>();
			foreach (var word in words)
			{
				if (expectedWords.ContainsKey(word))
				{
					expectedWords[word]++;
				}
				else
				{
					expectedWords.Add(word, 1);
				}
			}

			var numWords = words.Length;
			var wordLength = words[0].Length;
			var seenWords = new Dictionary<string, int>();

            /// at each index try to find it
			for (var index = 0; index < s.Length - numWords * wordLength + 1; index++)
			{
				var numWordsMatched = 0;
				seenWords.Clear();
				for (int subIndex = index; subIndex < index + numWords*wordLength; subIndex += wordLength)
				{
					var word = s.Substring(subIndex, wordLength);
                    // try to find the word in expected list if not then you cannot match so break
					if (!expectedWords.ContainsKey(word))
					{
						break;
					}
					if (seenWords.ContainsKey(word))
					{
						seenWords[word]++;
					}
					else
					{
						seenWords.Add(word, 1);
					}
                    // the word is seen more times than expected, than it is not a valid, break;
					if (seenWords[word] > expectedWords[word])
					{
						break;
					}
					numWordsMatched++;
				}
                // if the number of words matched are the same number of words, then you have found valid index.
				if(numWordsMatched == numWords)
				{
					list.Add(index);
				}
			}
			return list;
		}
	}
}
/*
 public class Solution
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
 
 */