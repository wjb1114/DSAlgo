using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigOOne
{
    public class OOfNExample
    {
        // Rule 1: Worst Case
        // Rule 2: Remove Constants
        // Rule 3: Different Terms for Inputs
        // Rule 4: Drop Non Dominants

        public void TestLinear()
        {
            var strings = new List<string> { "one", "two", "three" };

            foreach (var s in strings)
            {
                if (s == "two")
                {
                    //Console.WriteLine("Found Two");
                }
            }
            Console.WriteLine("Single loop: O(n) time complexity, aka linear time.");
        }

        public void TestConstant(List<string> strings)
        {
            Console.WriteLine(strings[0]);
            Console.WriteLine("Regardless of input parameters, same number of steps taken. O(1), aka constant time");
        }

        public int ExcerciseOne(List<string> strings)
        {
            var a = 10;
            a = 50 + 3;

            for (int i = 0; i < strings.Count; i++)
            {
                //OtherMethod() - commented because it does not exist
                var stranger = true;
                a++;
            }
            Console.WriteLine("Loop executed once per item in string list, so time complexity is O(n)");
            return a;
        }

        public void ExcerciseTwo(int input)
        {
            var a = 5;
            var b = 10;
            var c = 50;
            for (int i = 0; i < input; i++)
            {
                var x = i + 1;
                var y = i + 2;
                var z = i = 3;
            }

            for (int j = 0; j < input; j++)
            {
                var p = j * 2;
                var q = j * 2;
            }

            var whoAmI = "I don't know";
            Console.WriteLine("Loop executed based on input value, so time complexity is O(n)");
        }

        public void SomeDumbNonsense(List<string> items)
        {
            Console.WriteLine(items.FirstOrDefault());

            var middleIndex = MathF.Floor(items.Count / 2);
            var index = 0;

            while (index < middleIndex) // O(n/2), simplified to O(n)
            {
                Console.WriteLine(items[index]);
                index++;
            }

            for (var i = 0; i < 100; i++) // O(100) because iteration cound not dependent on input, simplifies to O(1), rule 2 example
            {
                Console.WriteLine("Hello there.");
            }

            Console.WriteLine("Single loop dependent on input length, O(n)");
        }

        public void MultipleInputs(List<string> inOne, List<string> inTwo)
        {
            foreach (var item in inOne)
            {
                Console.WriteLine(item);
            }

            foreach (var item in inTwo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("O(a + b), as each input has a loop attached. See rule 3");
        }

        public void LogAllPairs(List<string> first)
        {
            foreach (var item in first)
            {
                for (var i = 0; i < first.Count; i++)
                {
                    Console.WriteLine(item + ", " + first[i]);
                }
            }

            Console.WriteLine("O(n^2) since there is a loop within a loop, each dependent on size of input");
        }

        public void LogAllPairsFromMultiple(List<string> first, List<string> second)
        {
            foreach (var item in first)
            {
                foreach (var other in second)
                {
                    Console.WriteLine(item + ", " + other);
                }
            }

            Console.WriteLine("O(a * b) since there is a loop within a loop, each dependent on size of a different input");
        }

        public void SomeOtherNonsense(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (var numOne in numbers)
            {
                foreach (var numTwo in numbers)
                {
                    Console.WriteLine(numOne + numTwo);
                }
            }

            Console.WriteLine("O(n + n^2), simplifies to O(n^2) because it is the most dominant value. See Rule 4.");
        }

        public void Boo(List<string> n)
        {
            for (var i = 0; i < n.Count; i++)
            {
                Console.WriteLine("Boo");
            }

            Console.WriteLine("Space Complexity of O(1) since no new variables are created inside the method.");
        }

        public List<string> ArrayNTimes(int n)
        {
            var hiArray = new List<string>();
            for (var i = 0; i < n; i++)
            {
                hiArray.Add("hi");
            }

            Console.WriteLine("Space complexity O(n), and more space in memory is used for each item in the lsit, and the list size corresponds to the size of the input value.");
            return hiArray;
        }

        public KeyValuePair<string, string> GetFirstAndLast(List<string> tweets)
        {
            Console.WriteLine("O(1) time complexity, O(1) space complexity");
            return new KeyValuePair<string, string>(tweets[0], tweets[tweets.Count - 1]);
        }

        public KeyValuePair<Tweet, Tweet> GetFirstAndLastDateCompare(List<Tweet> tweets)
        {
            Tweet first = null;
            Tweet last = null;

            foreach (var tweet in tweets)
            {
                if (first == null || first.Date > tweet.Date)
                {
                    first = tweet;
                }

                if (last == null || last.Date < tweet.Date)
                {
                    last = tweet;
                }
            }

            Console.WriteLine("Time complexity O(n) because of single loop dependent on input length.");
            Console.WriteLine("Space complexity O(1) because 2 variables created regardless of input length.");

            return new KeyValuePair<Tweet, Tweet>(first, last);
        }
    }
}
