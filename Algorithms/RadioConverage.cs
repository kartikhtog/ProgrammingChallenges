using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class RadioConverage
	{
        /*
        * Complete the 'hackerlandRadioTransmitters' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER_ARRAY x
        *  2. INTEGER k
        */

        public static int hackerlandRadioTransmitters(List<int> houses, int rangeOfTower)
        {
            if (houses==null ||houses.Count == 0)
			{
                return 0;
			}
            if (houses.Count == 1)
			{
                return 1;
			}
            houses.Sort();
            var radiosNeeded = 0;
            var maxHouseCovered = 0;

            int indexOfPossibleRadioHouse = 0;
            int minHouseIndexCovertedInRange = 0;
            var goToNextHouse = true;
            while (indexOfPossibleRadioHouse < houses.Count)
            {
                goToNextHouse = true;
                maxHouseCovered = MaxHouseInRange(houses[indexOfPossibleRadioHouse], rangeOfTower);
                if (1 + indexOfPossibleRadioHouse == houses.Count)
				{
                    radiosNeeded++;
                    break;
				}
                // look ahead, see if min index house will be in the range,
                if (houses[minHouseIndexCovertedInRange] < MinHouseInRange(houses[indexOfPossibleRadioHouse+1],rangeOfTower))
				{
                    // if not, set the tower to house
                    radiosNeeded++;
                    // keep moving till, you reach max Range house
                    while (indexOfPossibleRadioHouse < houses.Count &&  maxHouseCovered >= houses[indexOfPossibleRadioHouse])
                    {
                        // start again.
                        indexOfPossibleRadioHouse++;
                        minHouseIndexCovertedInRange = indexOfPossibleRadioHouse;
                        goToNextHouse = false;
                    }
				}
                
                if (goToNextHouse)
				{
                    indexOfPossibleRadioHouse++;
				}
            }

            return radiosNeeded;
        }
        public static int MinHouseInRange(int house, int range)
		{
            return house - range;
		}
        public static int MaxHouseInRange(int house, int range)
		{
            return house + range;
		}
    }
}
