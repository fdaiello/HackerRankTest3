using System;
using System.Collections.Generic;

namespace HackerRankTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPairs();
        }

        static void TestTrucTour()
        {
            List<List<int>> circle = new List<List<int>>()
                        {
                            new List<int>{ 1, 5 },
                            new List<int>{ 10, 3 },
                            new List<int>{ 3, 4 }
                        };

            Console.WriteLine(Result.truckTour(circle));
        }
        static void TestPairs()
        {
            List<int> arr = new List<int>() { -1, 1, 5, 3 };
            int target = 2;

            Console.WriteLine(Result.pairs(target, arr));
        }

        static void TestBigSorting()
        {
            List<string> list = new List<string> () { "100", "300", "5", "-5", "22298798798797987979879797887", "800", "1", "-800" };

            Console.WriteLine(String.Join(",", Result.bigSorting(list)));
        }
    }
}
