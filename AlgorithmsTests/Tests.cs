using Algorithms;
using Algorithms.Amazon;
using Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

/// <summary>
/// These are not robust test. These are just to easily walk throught
/// </summary>
namespace AlgorithmTests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void MaxAreaUnderLinesTest()
		{
			var sol = new MaxAreaUnderLines().MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

			Assert.AreEqual(49, sol);
		}


		[TestMethod]
		public void NumberOfEquivalentDominoPairs()
		{
			var dom = new int[8][];
			dom[0] = new int[] { 2, 1 };
			dom[1] = new int[] { 1, 2 };
			dom[2] = new int[] { 1, 2 };
			dom[3] = new int[] { 1, 2 };
			dom[4] = new int[] { 2, 1 };
			dom[5] = new int[] { 1, 1 };
			dom[6] = new int[] { 1, 2 };
			dom[7] = new int[] { 2, 2 };

			var numEqual = new SimilarDominoes().NumEquivDominoPairs(dom);

			Assert.AreEqual(15, numEqual);

		}

		[TestMethod]
		public void AnyTwoNodesSumsToTargetTest()
		{
			var two = new TreeNode(2);
			var one = new TreeNode(1);
			var four = new TreeNode(4);
			two.left = one;
			two.right = four;
			var newOne = new TreeNode(1);
			var zero = new TreeNode(0);
			var three = new TreeNode(3);
			newOne.left = zero;
			newOne.right = three;

			var isTrue = new AnyTwoNodesSumsToTarget().TwoSumBSTs(two, newOne, 5);

			Assert.AreEqual(true, isTrue);
		}


		[TestMethod]
		public void GenerateSentencesWithSynonymsTest()
		{
			var synonyms = new List<IList<string>>();
			synonyms.Add(new List<string>() { "happy", "joy" });
			synonyms.Add(new List<string>() { "sad", "sorrow" });
			synonyms.Add(new List<string>() { "joy", "cheerful" });
			var generatedSentences = new Synonyms().GenerateSentences(synonyms, "I am happy today but was sad yesterday");
			//foreach (var s in generatedSentences) { Console.WriteLine(s); }
			Assert.AreEqual(6, generatedSentences.Count);
		}

		[TestMethod]
		public void GenerateSentencesWithSynonymsTest2()
		{
			var synonyms = new List<IList<string>>();
			synonyms.Add(new List<string>() { "a", "QrbCl" });
			var generatedSentences = new Synonyms().GenerateSentences(synonyms, "d QrbCl ya ya NjZQ");
			//foreach (var s in generatedSentences) { Console.WriteLine(s); }
			Assert.AreEqual(2, generatedSentences.Count);
		}
		[TestMethod]
		public void GenerateSpiralTest()
		{
			var spiral = new GenerateSpiralOfNumbers().GenerateMatrix(3);
			Assert.AreEqual(1, spiral[0][0]);
			Assert.AreEqual(2, spiral[0][1]);
			Assert.AreEqual(3, spiral[0][2]);
			Assert.AreEqual(4, spiral[1][2]);
			Assert.AreEqual(5, spiral[2][2]);
			Assert.AreEqual(6, spiral[2][1]);
			Assert.AreEqual(7, spiral[2][0]);
			Assert.AreEqual(8, spiral[1][0]);
			Assert.AreEqual(9, spiral[1][1]);
		}

		[TestMethod]
		public void IsSubTreeTest()
		{
			var three = new TreeNode(3);
			var four = new TreeNode(4);
			var five = new TreeNode(5);
			var one = new TreeNode(1);
			var two = new TreeNode(2);
			three.left = four;
			three.right = five;
			four.left = one;
			four.right = two;

			var isSubTree = new IsSubTree().IsSubtree(three, four);

			Assert.AreEqual(true, isSubTree);
		}
		[TestMethod]
		public void DietPlanPerformanceTest()
		{
			var s = new CalsYo().DietPlanPerformance(new int[] { 6, 5, 0, 0 }, 2, 1, 5);

			Assert.AreEqual(0, s);
		}


		[TestMethod]
		public void FindPositionOfWordsTest()
		{
			var haha = new FindPositionOfWords().FindSubstring("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "good" });
			haha = new FindPositionOfWords().FindSubstring("a", new string[] { "a" });


			//solution is very bad for many words..doesn't complete

			Assert.Inconclusive();
			haha = new FindPositionOfWords().FindSubstring("pjzkrkevzztxductzzxmxsvwjkxpvukmfjywwetvfnujhweiybwvvsrfequzkhossmootkmyxgjgfordrpapjuunmqnxxdrqrfgkrsjqbszgiqlcfnrpjlcwdrvbumtotzylshdvccdmsqoadfrpsvnwpizlwszrtyclhgilklydbmfhuywotjmktnwrfvizvnmfvvqfiokkdprznnnjycttprkxpuykhmpchiksyucbmtabiqkisgbhxngmhezrrqvayfsxauampdpxtafniiwfvdufhtwajrbkxtjzqjnfocdhekumttuqwovfjrgulhekcpjszyynadxhnttgmnxkduqmmyhzfnjhducesctufqbumxbamalqudeibljgbspeotkgvddcwgxidaiqcvgwykhbysjzlzfbupkqunuqtraxrlptivshhbihtsigtpipguhbhctcvubnhqipncyxfjebdnjyetnlnvmuxhzsdahkrscewabejifmxombiamxvauuitoltyymsarqcuuoezcbqpdaprxmsrickwpgwpsoplhugbikbkotzrtqkscekkgwjycfnvwfgdzogjzjvpcvixnsqsxacfwndzvrwrycwxrcismdhqapoojegggkocyrdtkzmiekhxoppctytvphjynrhtcvxcobxbcjjivtfjiwmduhzjokkbctweqtigwfhzorjlkpuuliaipbtfldinyetoybvugevwvhhhweejogrghllsouipabfafcxnhukcbtmxzshoyyufjhzadhrelweszbfgwpkzlwxkogyogutscvuhcllphshivnoteztpxsaoaacgxyaztuixhunrowzljqfqrahosheukhahhbiaxqzfmmwcjxountkevsvpbzjnilwpoermxrtlfroqoclexxisrdhvfsindffslyekrzwzqkpeocilatftymodgztjgybtyheqgcpwogdcjlnlesefgvimwbxcbzvaibspdjnrpqtyeilkcspknyylbwndvkffmzuriilxagyerjptbgeqgebiaqnvdubrtxibhvakcyotkfonmseszhczapxdlauexehhaireihxsplgdgmxfvaevrbadbwjbdrkfbbjjkgcztkcbwagtcnrtqryuqixtzhaakjlurnumzyovawrcjiwabuwretmdamfkxrgqgcdgbrdbnugzecbgyxxdqmisaqcyjkqrntxqmdrczxbebemcblftxplafnyoxqimkhcykwamvdsxjezkpgdpvopddptdfbprjustquhlazkjfluxrzopqdstulybnqvyknrchbphcarknnhhovweaqawdyxsqsqahkepluypwrzjegqtdoxfgzdkydeoxvrfhxusrujnmjzqrrlxglcmkiykldbiasnhrjbjekystzilrwkzhontwmehrfsrzfaqrbbxncphbzuuxeteshyrveamjsfiaharkcqxefghgceeixkdgkuboupxnwhnfigpkwnqdvzlydpidcljmflbccarbiegsmweklwngvygbqpescpeichmfidgsjmkvkofvkuehsmkkbocgejoiqcnafvuokelwuqsgkyoekaroptuvekfvmtxtqshcwsztkrzwrpabqrrhnlerxjojemcxel", new string[]
			{ "dhvf", "sind", "ffsl", "yekr", "zwzq", "kpeo", "cila", "tfty", "modg", "ztjg", "ybty", "heqg", "cpwo", "gdcj", "lnle", "sefg", "vimw", "bxcb" });
			//foreach (var ha in haha)
			//{
			//    Console.WriteLine(ha);
			//}
		}

		[TestMethod]
		public void CutOffTreeTest()
		{
			var forest = new List<IList<int>>();
			forest.Add(new List<int>() { 54581641, 64080174, 24346381, 69107959 });
			forest.Add(new List<int>() { 86374198, 61363882, 68783324, 79706116 });
			forest.Add(new List<int>() { 668150, 92178815, 89819108, 94701471 });
			forest.Add(new List<int>() { 83920491, 22724204, 46281641, 47531096 });
			forest.Add(new List<int>() { 89078499, 18904913, 25462145, 60813308 });

			var stepsToCutOffAllTrees = new CutTress().CutOffTree(forest);

			Assert.AreEqual(45, stepsToCutOffAllTrees);
		}

		[TestMethod]
		public void MostCommonWordNotInListTest()
		{
			var solution = new MostCommon().MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
			Assert.AreEqual("ball", solution);
		}

		[TestMethod]
		public void MostCommonWordNotInListTest2()
		{
			var solution = new MostCommon().MostCommonWord("a", new string[] { });
			Assert.AreEqual("a", solution);
		}

		[TestMethod]
		public void MergeKListTest()
		{
			var listNode1 = new ListNode(1).Insert(4, 5);
			var listNode2 = new ListNode(1).Insert(3, 3);
			var listNode3 = new ListNode(1).Insert(2);
			ListNode[] lists = new ListNode[3] { listNode1, listNode2, listNode3 };


			var mergedList = new MergeLists().MergeKLists(lists);

			Assert.AreEqual(1, mergedList.val); mergedList = mergedList.next;
			Assert.AreEqual(1, mergedList.val); mergedList = mergedList.next;
			Assert.AreEqual(1, mergedList.val); mergedList = mergedList.next;
			Assert.AreEqual(2, mergedList.val); mergedList = mergedList.next;
			Assert.AreEqual(3, mergedList.val); mergedList = mergedList.next;
			Assert.AreEqual(3, mergedList.val); mergedList = mergedList.next;
			Assert.AreEqual(4, mergedList.val); mergedList = mergedList.next;
			Assert.AreEqual(5, mergedList.val);
			Assert.IsNull(mergedList.next);

			//while (true)
			//{
			//    if (mergedList != null)
			//    {
			//        Console.Write(" {0} ", mergedList.val);
			//    }
			//    else
			//    {
			//        break;
			//    }
			//    mergedList = mergedList.next;
			//}
		}

		[TestMethod]
		public void KClosedPointsTest()
		{
			// k points to 0,0
			int[][] points = new int[2][] { new int[2] { -2, 2 }, new int[2] { 1, 3 } };
			var results = new KClosestPoints().KClosest(points, 1);

			Assert.AreEqual(-2, results[0][0]);
			Assert.AreEqual(2, results[0][1]);

		}

		[TestMethod]
		public void KClosedPointsTest2()
		{
			int[][] points = new int[2][] { new int[2] { 1, 3 }, new int[2] { -2, 2 } };
			var results = new KClosestPoints().KClosest(points, 1);

			Assert.AreEqual(-2, results[0][0]);
			Assert.AreEqual(2, results[0][1]);
		}


		[TestMethod]
		public void NoDupTest()
		{
			var sortedInts = new int[] { 1, 2, 2, 3, 4, 4, 5, 5, 6, 6, 6, 7 };

			var sortedUpTo = new RemoveDupsFromSortedArray().RemoveDuplicates(sortedInts);

			for (int i = 0; i < sortedUpTo; i++)
			{
				Assert.AreEqual(i + 1, sortedInts[i]);
			}
		}

		[TestMethod]
		public void RotateByKTest()
		{
			// setup
			var bunchOfInts = new int[] { -1, -100, 3, 99 };
			// act
			new RotateByK().Rotate(bunchOfInts, 2);

			// assert
			Assert.AreEqual(3, bunchOfInts[0]);
			Assert.AreEqual(99, bunchOfInts[1]);
			Assert.AreEqual(-1, bunchOfInts[2]);
			Assert.AreEqual(-100, bunchOfInts[3]);
		}

		[TestMethod]
		public void StringToIntTest()
		{
			//var minValue = int.MinValue + 100;
			//Console.WriteLine(minValue*10);
			var input = "-19";
			//Console.WriteLine(string.Format("input: {0:0,0}", input));
			var result = new StringToInt().MyAtoi(input);
			//Console.WriteLine(string.Format("Result: {0:0,0}", result));
			Assert.AreEqual(-19, result);
		}

		[TestMethod]
		public void TelephoneDigitsToCombinationsTest()
		{
			//Console.WriteLine("Hello World!");
			var input = "23";
			var solution = new TelephoneDigitsToCombinations().LetterCombinations(input);
			//Console.WriteLine(solution);
			//foreach (var value in solution)
			//{
			//    Console.Write(" {0} ", value);
			//}
			//Console.WriteLine();
			Assert.AreEqual(9, solution.Count);
		}

		[TestMethod]
		public void ApplicationPairsTest()
		{
			var list1 = new List<List<int>>();
			list1.Add(new List<int>() { 1, 8 });
			list1.Add(new List<int>() { 2, 7 });
			list1.Add(new List<int>() { 3, 14 });
			var list2 = new List<List<int>>();
			list2.Add(new List<int>() { 1, 5 });
			list2.Add(new List<int>() { 2, 10 });
			list2.Add(new List<int>() { 3, 14 });
			var r = new ApplicationPairs().ApplicationPairsAlgorithm(20, list1, list2);
			foreach (var a in r)
			{
				foreach (var b in a)
				{
					Console.Write(b + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine(r);
			Assert.Inconclusive();
		}


		[TestMethod]
		public void HowMuchWaterCanHoldTest()
		{
			var result = new HowMuchWaterCanBeTrappedInside().Trap(null);
			Assert.Fail();
		}

		[TestMethod]
		public void ValidParentheseTest()
		{
			var validParen = new ValidParentheses();
			var parentheses = "({[()]})";
			var isValid = validParen.IsValid(parentheses);
			Assert.AreEqual(true, isValid);
		}

		[TestMethod]
		public void PrintStackTest()
		{
			var Opertions = new List<String>();
			Opertions.Add("4");
			Opertions.Add("1 83");
			Opertions.Add("3");
			Opertions.Add("2");
			Opertions.Add("1 76");
			var results = PrintStack.getMax(Opertions);
			foreach (var result in results)
			{
				Console.WriteLine(result);
			}
		}
		[TestMethod]
		public void FindContactsTest()
		{
			var input = ReadInputFile("FindContacts.txt");
			var output = new List<int>();
			foreach (var line in ReadOutputFile("FindContacts.txt"))
			{
				output.Add(int.Parse(line.Trim()));
			}


			var Operations = new List<List<String>>();
			//         Opertions.Add(new List<string> { "add", "hack" });
			//         Opertions.Add(new List<string> { "add", "hackerrank" });
			//         Opertions.Add(new List<string> { "find", "hac" });
			//         Opertions.Add(new List<string> { "find", "hak" });
			var numOps = int.Parse(input[0].Trim());
			var findStrings = new List<string>();
			for (var index = 1; index < numOps; index++)
			{
				var operation = input[index].Split(' ');
				Operations.Add(new List<string> { operation[0].Trim(), operation[1].Trim() });
				if (operation[0].Trim() == "find")
				{
					findStrings.Add(input[index]);
				}
			}
			var results = FindContacts.contacts(Operations);
			if (results.Count != output.Count)
			{
				Console.WriteLine("Count not equal");
				Console.WriteLine("Result.count " + results.Count);
				Console.WriteLine("output.count " + output.Count);
				Assert.AreEqual(output.Count, results.Count);

			}
			var minCount = results.Count < output.Count ? results.Count : output.Count;
			for (int i = 0; i < minCount; i++)
			{
				if (results[i] != output[i])
				{
					Assert.AreEqual(output[i], results[i]);
					Console.WriteLine(
						String.Format("{0}){1} Expected: {2}, Actual: {3}", i, findStrings[i], output[i], results[i])
						);
				}
				else
				{

				}
			}
		}
		[TestMethod]
		public void CompareSortingAlorithms()
		{
			var numItems = 10000;
			var bubble = TestSortingAlorithm(numItems, BubbleSort<int>.Sort, "BubbleSort").TotalMilliseconds;
			var merge = TestSortingAlorithm(numItems, MergeSort<int>.Sort, "MergeSort").TotalMilliseconds;
			var quick = TestSortingAlorithm(numItems, QuickSort<int>.Sort, "QuickSort").TotalMilliseconds;
			var max = HelperMethods<int>.Max(bubble, merge, quick);
			Console.WriteLine(string.Format(
				"BubbleSort: {0:P}\nMergeSort: {1:P}\nQuickSort: {2:P}\n", 
				bubble/ max, 
				merge / max,
				quick / max));
		}

		[TestMethod]
		public void BubbleSortTest()
		{
			TestSortingAlorithm(1000, BubbleSort<int>.Sort, "BubbleSort");
		}
		[TestMethod]
		public void MergeSortTest()
		{
			//TestSortingAlorithm(100, MergeSort<int>.Sort, "MergeSort", enableDebug: true);
			TestSortingAlorithm(1000, MergeSort<int>.Sort, "MergeSort");
		}
		[TestMethod]
		public void QuickSortTest()
		{
			TestSortingAlorithm(10000, QuickSort<int>.Sort, "QuickSort", enableDebug: false);
		}	
		[TestMethod]
		public void RedixSortTest()
		{
			TestSortingAlorithm(1000, RadixSort.Sort, "RadixSort", enableDebug: true);
		}


		public TimeSpan TestSortingAlorithm(int lengthOfRandomList, Func<int[],int[]> sortingAlorithm, string sortingAlorithmType = "Implmented", bool enableDebug = false)
		{
			var randomGenerator = new Random(2021);
			var randomGeneratedList = new List<int>();
			for (int i = 0; i < lengthOfRandomList; i++)
			{
				randomGeneratedList.Add(randomGenerator.Next(-1*(lengthOfRandomList-1), lengthOfRandomList));
			}
			var copyOfGeneratedList = randomGeneratedList.Select(x => x);
			var inputForSorting = randomGeneratedList.ToArray();

			var stopWatch = new Stopwatch();

			// out Sorting Time
			stopWatch.Start();
			var sortedListResult = sortingAlorithm(inputForSorting);
			stopWatch.Stop();
			var ourAlgorithmSortingTime = stopWatch.Elapsed;
			
			stopWatch.Reset();

			// Linq sorting time.
			stopWatch.Start();
			var linqSortedList = copyOfGeneratedList.OrderBy(x => x);
			stopWatch.Stop();
			var linqSortingTime = stopWatch.Elapsed;
			
			Console.WriteLine("{0,-14}: {1}.", sortingAlorithmType, ourAlgorithmSortingTime);
			Console.WriteLine("{0,-14}: {1}.", "Linq", linqSortingTime);

			var linqSortedArray = linqSortedList.ToArray();

			for (int i = 0; i < lengthOfRandomList; i++)
			{
				if (enableDebug)
				{
					Console.WriteLine(string.Format("Expected: {0}, Actual: {1}", linqSortedArray[i], sortedListResult[i]));
				}
				else
				{
					Assert.AreEqual(linqSortedArray[i], sortedListResult[i]);
				}
			}
			return ourAlgorithmSortingTime;
		}

		[TestMethod]
		public void RadioCoverageTest()
		{
			var list = new List<int>();
			list.Add(1);list.Add(2); list.Add(3); list.Add(4);list.Add(5);
			var range = 1;
			var numRadios = RadioConverage.hackerlandRadioTransmitters(list, range);
			Assert.AreEqual(2, numRadios);
		}
		[TestMethod]
		public void IceCreamParlorTest()
		{
			var list = new List<int>();
			list.AddItems(1, 4, 5, 3, 2);
			var money = 4;
			var numRadios = icecreamParlorClass.icecreamParlor(money, list);
			Assert.AreEqual(1, numRadios[0]);
			Assert.AreEqual(4, numRadios[1]);
		}	
		[TestMethod]
		public void IceCreamParlorTest2()
		{
			
			var list = new List<int>();
			var array = "5 75 25";
			var array2 = array.Split(' ');
			foreach(var item in array2)
			{
				list.Add(int.Parse(item));
			}
			var money = 100;
			var numRadios = icecreamParlorClass.icecreamParlor(money, list);
			Assert.AreEqual(2, numRadios[0]);
			Assert.AreEqual(3, numRadios[1]);
		}
	
		[TestMethod]
		public void KightsOnAChessBoardTest() 
		{
			var result = KnightlOnAChessboardClass.knightlOnAChessboard(10);
			foreach (var list in result)
			{
				Console.Write(String.Format("{0,-1}","["));
				foreach(var item in list){
					Console.Write(string.Format("{0,4:N0}" ,item));
				}
				Console.Write(String.Format("{0,3}","]"));
				Console.WriteLine();
			}
		}



		[TestMethod]
		public void MinHeapTest()
		{
			var list = new List<string>();
			list.AddItems("1 4", "1 9", "3", "2 4", "3");
			var minHeap = new MinHeap(list);
		}
		
		[TestMethod]
		public void MinHeapTest2()
		{
			var list = new List<string>();
			list.AddItems("1 286789035",
							"1 255653921",
							"1 274310529",
							"1 494521015",
							"3			",
							"2 255653921",
							"2 286789035",
							"3			",
							"1 236295092",
							"1 254828111",
							"2 254828111",
							"1 465995753",
							"1 85886315	",
							"1 7959587	",
							"1 20842598	",
							"2 7959587	",
							"3			",
							"1 -51159108",
							"3			",
							"2 -51159108",
							"3			",
							"1 789534713"
							);
			var minHeap = new MinHeap(list);
		}


		[TestMethod]
		public void MinHeapTest3()
		{
			var input = ReadInputFile("heapinput.txt").ToList();
			input = input.GetRange(1, input.Count() - 1);
			var minHeapOutput = new MinHeap(input, storeValue: true, printToConsole: false);
			var expected = ReadOutputFile("heapoutput.txt").ToList().Select(x => int.Parse(x)).ToList();
			var actual = minHeapOutput.Values;
			var min = expected.Count < actual.Count ? expected.Count : actual.Count;
			for (int i = 0; i < min; i++)
			{
				Console.WriteLine(string.Format("expected vs actual {0}:{1}",expected[i],actual[i]));
				Assert.AreEqual(expected[i], actual[i]);
			}
			Assert.AreEqual(expected.Count, actual.Count);

			
		}	
		[TestMethod]
		public void NumOnesTest()
		{
			var random = new Random();
			var list = new List<uint>();
			for(int i =0;i< 10000; i++)
			{
				uint thirtyBits = (uint)random.Next(1 << 30);
				uint twoBits = (uint)random.Next(1 << 2);
				uint fullRange = (thirtyBits << 2) | twoBits;
				list.Add(fullRange);
			}
			var list2 = new List<uint>();
			foreach(var item in list)
			{
				list2.Add(item);
			}
			var stopWatch = new Stopwatch();
			stopWatch.Start();
			foreach (var item in list2)
			{
				NumOnes.HammingWeight(item);
			}
			stopWatch.Stop();
			Console.WriteLine(string.Format("Time Elaped using bitwise method is {0}", stopWatch.Elapsed));
			stopWatch.Reset();
			// out Sorting Time
			stopWatch.Start();
			foreach(var item in list)
			{
				NumOnes.HammingWeight2(item);
			}
			stopWatch.Stop();
			Console.WriteLine(string.Format("Time Elaped using string method is {0}", stopWatch.Elapsed));
			stopWatch.Reset();
		}
				
		[TestMethod]
		public void RunningMedianTest()
		{
			var input = new List<int>();
			input.AddItems(
							1,
							2,
							3,
							4,
							5,
							6);
			var hey = new MedianNumber();
			var returnitems = hey.runningMedian(input);
			

			
		}



		public string[] ReadInputFile(string fileName)
		{
			return System.IO.File.ReadAllLines(Path.Combine("Inputs", fileName));
		}
		public string[] ReadOutputFile(string fileName)
		{
			return System.IO.File.ReadAllLines(Path.Combine("Outputs", fileName));
		}
	}
}
/*
 List<int> input = new List<int>();

// first read input till there are nonempty items, means they are not null and not ""
// also add read item to list do not need to read it again    
string line;
while ((line = Console.ReadLine()) != null && line != "") {
     input.Add(int.Parse(line));
}

 */
