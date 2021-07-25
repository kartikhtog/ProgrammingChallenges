using System.Collections.Generic;

namespace Algorithms
{
    public class CalsYo
    {
        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            var totalPoints = 0;
            var caloriesInLastKDays = new List<int>();
            for (int i = 0; i < calories.Length; i++)
            {
                var add = calories[i];
                if (i - 1 >= 0)
                {
                    add += caloriesInLastKDays[i - 1];
                }
                var remove = 0;
                if (i - k >= 0)
                {
                    remove = calories[i - k];
                }
                caloriesInLastKDays.Add(add - remove);
            }
            for (int i = k - 1; i < caloriesInLastKDays.Count; i++)
            {
                var calsAte = caloriesInLastKDays[i];
                if (calsAte < lower)
                {
                    totalPoints--;
                }
                if (calsAte > upper)
                {
                    totalPoints++;
                }
            }
            return totalPoints;
        }

    }
}