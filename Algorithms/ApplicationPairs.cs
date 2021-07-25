using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Amazon
{
    public class ApplicationPairs
    {
        /*
    * Complete the 'applicationPairs' function below.
    *
    * The function is expected to return a 2D_INTEGER_ARRAY.
    * The function accepts following parameters:
    *  1. INTEGER deviceCapacity
    *  2. 2D_INTEGER_ARRAY foregroundAppList
    *  3. 2D_INTEGER_ARRAY backgroundAppList
    */

        //public List<List<int>> ApplicationPairs(int deviceCapacity, List<List<int>> foregroundAppList, List<List<int>> backgroundAppList)
        //{
        //    var IDPairsList = new List<List<int>>();


        //    //foregroundAppList = foregroundAppList.OrderBy(app=>app[1]).ToList();
        //    //backgroundAppList = foregroundAppList.OrderByDescending(app=>app[1]).ToList();

        //    // move forward in foreground apps as you move backwards to backgroundapplist to pair them up.

        //    //int indexOfForeGround = 0;
        //    //int indexOfBackGround = backgroundAppList.Count -1;

        //    int indexOfFore = 0;
        //    int indexOfBack = 0;
        //    for (int i = 0; i < foregroundAppList.Count; i++)
        //    {
        //        int maxtotalTime = int.MinValue;
        //        for (int j = 0; j < backgroundAppList.Count; j++)
        //        {
        //            int currentTotalForPair = foregroundAppList[i][1] + backgroundAppList[j][1];

        //            if (currentTotalForPair > maxtotalTime && currentTotalForPair <= deviceCapacity)
        //            {
        //                maxtotalTime = currentTotalForPair;
        //                indexOfFore = i;
        //                indexOfBack = j;
        //            }
        //        }
        //        int bestTimeForPair = foregroundAppList[indexOfFore][1] + backgroundAppList[indexOfBack][1];
        //        if (bestTimeForPair >= 0 && bestTimeForPair <= deviceCapacity)
        //        {
        //            IDPairsList.Add(new List<int>() { foregroundAppList[indexOfFore][0], backgroundAppList[indexOfBack][0] });
        //            foregroundAppList.RemoveAt(indexOfFore);
        //            backgroundAppList.RemoveAt(indexOfBack);
        //            i--;
        //        }
        //    }


        //    return IDPairsList;
        //}
        /*
    * Complete the 'applicationPairs' function below.
    *
    * The function is expected to return a 2D_INTEGER_ARRAY.
    * The function accepts following parameters:
    *  1. INTEGER deviceCapacity
    *  2. 2D_INTEGER_ARRAY foregroundAppList
    *  3. 2D_INTEGER_ARRAY backgroundAppList
    */

        public List<List<int>> ApplicationPairsAlgorithm(int deviceCapacity, List<List<int>> foregroundAppList, List<List<int>> backgroundAppList)
        {
            var IDPairsList = new List<List<int>>();


            // sort not required currently.

            //foregroundAppList = foregroundAppList.OrderBy(app => app[1]).ToList();
            //backgroundAppList = foregroundAppList.OrderBy(app => app[1]).ToList();
            /// lets try a simple solution

            for (int d = deviceCapacity; d >= 0; d--)
            {
                var brokenInnerLoop = false;
                for (int i = 0; i < foregroundAppList.Count; i++)
                {
                    for (int j = 0; j < backgroundAppList.Count; j++)
                    {
                        if (foregroundAppList[i][1] + backgroundAppList[j][1] == d)
                        {
                            IDPairsList.Add(new List<int>() { foregroundAppList[i][0], backgroundAppList[j][0] });
                            foregroundAppList.RemoveAt(i);
                            backgroundAppList.RemoveAt(j);
                            brokenInnerLoop = true;
                            break;
                        }
                    }
                    if (brokenInnerLoop)
                    {
                        break;
                    }
                }
            }



            // int indexOfFore = 0;
            // int IdOfFore = 0;
            // int indexOfBack = 0;
            // int IdOfBack = 0;
            // for(int i = 0; i < foregroundAppList.Count; i++){
            //     int maxtotalTime = int.MinValue;
            //     for(int j = 0; j < backgroundAppList.Count; j++) {
            //         int currentTotalForPair = foregroundAppList[i][1] + backgroundAppList[j][1];

            //         if (currentTotalForPair > maxtotalTime && currentTotalForPair <= deviceCapacity ){
            //             maxtotalTime = currentTotalForPair;
            //             indexOfFore = i;
            //             indexOfBack = j;
            //         }
            //     }
            //     int bestTimeForPair = foregroundAppList[indexOfFore][1] + backgroundAppList[indexOfBack][1];
            //     if (bestTimeForPair >= 0 && bestTimeForPair <= deviceCapacity){
            //         IDPairsList.Add(new List<int>(){foregroundAppList[indexOfFore][0],backgroundAppList[indexOfBack][0]});
            //         foregroundAppList.RemoveAt(indexOfFore);
            //         backgroundAppList.RemoveAt(indexOfBack);
            //         i--;
            //     }
            // }
            // arr. incorrent solution


            return IDPairsList;
        }
    }
}
