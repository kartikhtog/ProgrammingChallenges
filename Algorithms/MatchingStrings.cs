using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class MatchingStrings
	{
		/*
* Complete the 'matchingStrings' function below.
*
* The function is expected to return an INTEGER_ARRAY.
* The function accepts following parameters:
*  1. STRING_ARRAY strings
*  2. STRING_ARRAY queries
*/
		// O(m*n)
		public List<int> matchingStrings2(List<string> strings, List<string> queries)
		{
			var list = new List<int>();
			if (queries == null || queries.Count == 0)
			{
				return list;
			}
			if (strings != null)
			{
				for(int index = 0; index < queries.Count; index++)
				{
					list.Add(0);
					foreach (var s in strings)
					{
						if (queries[index] == s)
						{
							list[index]++;
						}
					}
				}
			}
			return list;
		}
		// for repeated words
		// O(m+n)
		// larger spacial complexicity
		// lower run time
		public List<int> matchingStrings(List<string> strings, List<string> queries)
		{
			var list = new List<int>();
			if (queries == null || queries.Count == 0)
			{
				return list;
			}
			var words = new Dictionary<string, int>();
			if (strings != null)
			{
				foreach(var word in strings) // O(n)
				{
					if (words.ContainsKey(word)) // o(1)
					{
						words[word]++;
					}
					else
					{
						words.Add(word, 1); // O(1)
					}
				}
			}
			for (int index = 0; index < queries.Count; index++) // O(m)
			{
				if (words.ContainsKey(queries[index])) // O(1)
				{
					list.Add(words[queries[index]]); // O(1)
				}
				else
				{
					list.Add(0);
				}
			}

			return list;
		}
	}
}
