using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Algorithms
{
	public class FindContacts
	{
		public class TrieRoot : Trie
		{
			public override void Insert(string characters)
			{
				if (!branches.ContainsKey(characters[0]))
				{
					branches.Add(characters[0], new Trie());
				}
				branches[characters[0]].Insert(characters);
			}
			public override int FindCount(string characters)
			{
				if (branches.ContainsKey(characters[0]))
				{
					return branches[characters[0]].FindCount(characters);
				}
				return 0;
			}

			public TrieRoot()
			{
				Letter = '\0';
			}
			public override int Count => 0;
			public override char Letter { get => '\0';}
		}
		public class Trie
		{
			public virtual char Letter { get; set; } = '\0';
			protected Dictionary<char, Trie> branches = new Dictionary<char, Trie>();
			public virtual int Count { get; private set; } = 0;

			public Trie()
			{
			}
			public Trie(char letter)
			{
				Letter = letter;
				Count++;
			}


			public virtual void Insert(string characters)
			{
				// This should be a precondition really
				if (characters.Count() == 0)
				{
					return;
				}
				Letter = characters[0];
				Count++;
				if (characters.Count() > 1)
				{
					if (!branches.ContainsKey(characters[1]))
					{
						branches.Add(characters[1], new Trie());
					}
					branches[characters[1]].Insert(characters.Substring(1));
				}
			}
			/// <summary>
			/// Find the count of Characters is the Trie
			/// </summary>
			/// <param name="characters">cannot be null or of length 0</param>
			/// <returns></returns>
			public virtual int FindCount(string characters)
			{
				if (string.IsNullOrEmpty(characters))
				{
					return 0;
				}
				int count;
				if (characters[0] == Letter)
				{
					if(characters.Count() == 1)
					{
						count = Count;
					}
					else
					{
						if (branches.ContainsKey(characters[1]))
						{
							count = branches[characters[1]].FindCount(characters.Substring(1));
						}
						else
						{
							count = 0;
						}
					}
				}
				else
				{
					count = 0;
				}
				return count;
			}
		}
		public static List<int> contacts(List<List<string>> queries)
		{
			var contacts = new TrieRoot();
			var contactsFount = new List<int>();
			foreach (var query in queries)
			{
				if (query[0] == "add")
				{
					contacts.Insert(query[1]);
				}
				else
				{
					var numFound = contacts.FindCount(query[1]);
					
					contactsFount.Add(numFound);
				}
			}
			return contactsFount;
		}
		public static List<int> contacts2(List<List<string>> queries)
		{
			var contacts = new List<String>();
			var contactsFount = new List<int>();
			foreach(var query in queries)
			{
				if (query[0] == "add")
				{
					contacts.Add(query[1]);
				}
				else
				{
					var numFound =contacts.Count(x => x.StartsWith(query[1]));
					contactsFount.Add(numFound);
				}
			}
			return contactsFount;
		}

	}
}
