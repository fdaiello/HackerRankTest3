using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest3
{
    class Result
    {

        /*
         * Complete the 'truckTour' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY petrolpumps as parameter.
         */

        public static int truckTour(List<List<int>> petrolpumps)
        {
            // List for each node
            List<int> dif = new List<int>();

            // Loop nodes
            for ( int i=0; i < petrolpumps.Count; i++)
            {
                // Calc difference between petrol loaded and distance to next node
                dif.Add(petrolpumps[i][0] - petrolpumps[i][1]);
            }

            // Loop difference array
            for ( int i =0; i < dif.Count; i++)
            {
                int x = 0;
                int p1 = i;
                int sum = 0;
                while ( x < petrolpumps.Count)
                {
                    sum += dif[p1];
                    if (sum < 0)
                        break;
                    x++;
                    p1++;
                    if (p1 == petrolpumps.Count)
                        p1 = 0;
                }
                if (x < petrolpumps.Count)
                    continue;
                if (x == petrolpumps.Count)
                    return i;
            }

            return 0;

        }
        /*
         *  Number of pairs that have a difference equal to the target value
         */
        public static int pairs(int k, List<int> arr)
        {
            if (arr.Count < 1)
                return 0;

            // Pair needed
            int needed1, needed2;

            // List of values checked
            HashSet<int> visited = new HashSet<int>();

            // Count of satisfying pairs
            int c = 0;

            // Loop array
            for ( int i =0; i< arr.Count; i++)
            {
                needed1 = arr[i] + k;
                needed2 = arr[i] - k;
                if (visited.Contains(needed1) )
                {
                    c++;
                }
                if ( visited.Contains(needed2))
                {
                    c++;
                }
                visited.Add(arr[i]);
            }

            return c;
        }

        public static List<string> bigSorting(List<string> unsorted)
        {

           return unsorted.OrderBy(p => p.Length).ThenBy(p => p).ToList();

        }
    }
}
