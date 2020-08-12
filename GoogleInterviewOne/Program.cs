using System;
using System.Collections.Generic;

namespace GoogleInterviewOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOne = new List<int> { 0, 1, 2, 3, 4 };
            var listTwo = new List<int> { 5, 6, 7, 8, 9 };
            var listThree = new List<int> { -3, -2, 1, 5, 6, 7, 11, 14, 18, 21, 22 };
            var resOne = ArrayPairSum.GetPair(listOne, 3);
            var resTwo = ArrayPairSum.GetPair(listOne, 8);
            var resThree = ArrayPairSum.GetPair(listTwo, 13);
            var resFour = ArrayPairSum.GetPair(listTwo, 3);
            var resFive = ArrayPairSum.GetPair(listThree, 32);
            var resSix = ArrayPairSum.GetPair(listThree, 9);

            Console.WriteLine(resOne);
            Console.WriteLine(resTwo);
            Console.WriteLine(resThree);
            Console.WriteLine(resFour);
            Console.WriteLine(resFive);
            Console.WriteLine(resSix);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            resOne = ArrayPairSum.GetPairUnsorted(listOne, 3);
            resTwo = ArrayPairSum.GetPairUnsorted(listOne, 8);
            resThree = ArrayPairSum.GetPairUnsorted(listTwo, 13);
            resFour = ArrayPairSum.GetPairUnsorted(listTwo, 3);
            resFive = ArrayPairSum.GetPairUnsorted(listThree, 32);
            resSix = ArrayPairSum.GetPairUnsorted(listThree, 9);

            Console.WriteLine(resOne);
            Console.WriteLine(resTwo);
            Console.WriteLine(resThree);
            Console.WriteLine(resFour);
            Console.WriteLine(resFive);
            Console.WriteLine(resSix);

            // -3, -2, 1, 5, 6, 7, 11, 14, 18, 21, 22, sum 32
        }
    }
}
