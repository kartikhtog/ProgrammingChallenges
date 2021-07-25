using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class KClosestPoints
    {
        // k points closed to 0,0
        public int[][] KClosest(int[][] points, int k)
        {
            var dictionary = new Dictionary<int[], int>(); // points are unique but distances are not
            foreach (var point in points)
            {
                var distance = (point[0] * point[0] + point[1] * point[1]);
                dictionary.TryAdd(point, distance);
            }
            var orderedDictionary = dictionary.OrderBy(x => x.Value);
            var answer = new int[k][];

            var iterator = orderedDictionary.GetEnumerator();
            for (int i = 0; i < k; i++)
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
}