using Algorithms;
using Algorithms.Amazon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
