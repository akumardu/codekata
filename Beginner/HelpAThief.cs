using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    public struct GoldBox
    {
        public int numberOfPlates;
        public int coinsPerPlate;
    };

    class HelpAThief
    {
        
        public static void Help()
        {
            var list = new List<GoldBox>();
            list.Add(new GoldBox() { numberOfPlates = 1, coinsPerPlate = 3 });
            list.Add(new GoldBox() { numberOfPlates = 2, coinsPerPlate = 2 });
            list.Add(new GoldBox() { numberOfPlates = 3, coinsPerPlate = 1 });

            list.Sort(new GoldBoxComparer());

            int numberOfPlatesTaken = 0, numberOfPlatesThiefCanTake = 4, numberOfCoinsTaken = 0, index = 0;
            while(numberOfPlatesTaken < numberOfPlatesThiefCanTake)
            {
                if (numberOfPlatesThiefCanTake - numberOfPlatesTaken >= list[index].numberOfPlates)
                {
                    numberOfCoinsTaken = numberOfCoinsTaken + list[index].numberOfPlates * list[index].coinsPerPlate;
                }
                else
                {
                    int numberOfPlatesFromThisBox = numberOfPlatesThiefCanTake - numberOfPlatesTaken;
                    numberOfCoinsTaken = numberOfCoinsTaken + numberOfPlatesFromThisBox * list[index].coinsPerPlate;
                }
                index++;
                numberOfPlatesTaken += list[index].numberOfPlates;
            }
            Console.WriteLine(numberOfCoinsTaken);
        }
    }

    public class GoldBoxComparer : IComparer<GoldBox>
    {
        public int Compare(GoldBox x, GoldBox y)
        {
            return y.coinsPerPlate - x.coinsPerPlate;
        }
    }
}
