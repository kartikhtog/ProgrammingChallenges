using System.Collections.Generic;
using System.Linq;
//public class Solution
//{
//    // n is even
//    // ith candy is candyType[i]
//    // now eat n/2
//    public int DistributeCandies(int[] candyType)
//    {
//        var maxNumberCandies = candyType.Length / 2;
//        var dictionary = new Dictionary<int, int>();
//        for(int i = 0; i < candyType.Length; i++){
//            if (dictionary.ContainsKey(candyType[i]))
//            {
//                dictionary.Add(candyType[i], candyType[i]);
//            }
//        }
//        if (dictionary.Count < maxNumberCandies)
//        {
//            maxNumberCandies = dictionary.Count;
//        }
//        return maxNumberCandies;
//    }
//}
//public class Solution
//{
//    public string LongestPalindrome(string s)
//    {
//        var stack = new StringBuilder();
//        var longestPal = "";
//        var longestPalLen = 0;
//        var curLongestPal = new StringBuilder();
//        var curLongestPalLen = 0;
//        var newStack = false;
//        for(int i = 0;i < s.Length; i++)
//        {
//            if (!newStack)
//            {

//            }
//            if (curLongestPalLen >  longestPalLen)
//            {
//                longestPal = curLongestPal.ToString();
//                longestPalLen = curLongestPalLen;
//            }
//            curLongestPal = new StringBuilder();
//            curLongestPalLen = 0;
//            if (!newStack)
//            {
//                stack.Append(s[i]);
//            }
//            if (stack.Length > 0 && stack[stack.Length - 1] == s[i])
//            {
//                newStack = true;
//                curLongestPalLen += 2;
//                curLongestPal.Append(s[i]).Append(s[i]);
//                stack.Remove(stack.Length - 1, 1);

//                //currentLongestQueue;
//            }
//            else if(stack.Length > 1 && stack[stack.Length - 2] == s[i])
//            {
//                newStack = true;
//                curLongestPalLen += 3;
//                curLongestPal.Append(s[i]).Append(stack[stack.Length-1]).Append(s[i]);
//                stack.Remove(stack.Length - 2, 2);
//            }
//            else if (stack.Length > 0)
//            {
//                newStack = true;
//                curLongestPalLen += 1;
//                curLongestPal.Append(stack[stack.Length -1]);
//                stack.Remove(stack.Length - 1, 1);
//            }
//            else
//            {
//                newStack = false;
//            }
//        }
//        if (longestPal.Length == 0)
//        {
//            return s[0].ToString();
//        }
//        return longestPal.ToString();
//    }
//}
public class KClosestPoints
{
    // k points closed to 0,0
    public int[][] KClosest(int[][] points, int k)
    {
        var dictionary = new Dictionary<int[], int>(); // points are unique but distances are not
        foreach(var point in points)
        {
            var distance = (point[0] * point[0] + point[1] * point[1]);
            dictionary.TryAdd(point, distance);
        }
        var orderedDictionary = dictionary.OrderBy(x => x.Value);
        var answer = new int[k][];
        
        var iterator = orderedDictionary.GetEnumerator();
        for(int i = 0; i < k; i++)
        {
           iterator.MoveNext();
           answer[i] = iterator.Current.Key;
        }
        return answer;
    }
    public int[][] KClosest2(int[][] points, int k)
    {
        return points.OrderBy(x => x[0] * x[0] + x[1] * x[1]).Take(k).ToArray();
    }
}
