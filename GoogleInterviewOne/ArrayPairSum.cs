using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleInterviewOne
{
    public static class ArrayPairSum
    {
        /// <summary>
        /// Takes a list (in order, ascending) of integers and a sum, returns the items in the list (both value and index) that equal the given sum.
        /// </summary>
        /// <param name="values">List of integers to parse</param>
        /// <param name="sum">Value of 2 summed integers from list, assumed to be positive</param>
        /// <returns>Key Value pair containing index and value of the found integers</returns>
        public static KeyValuePair<KeyValuePair<int, int?>, KeyValuePair<int, int?>> GetPair(List<int> values, int sum)
        {
            KeyValuePair<int, int?> first = new KeyValuePair<int, int?>(0, values.First());
            KeyValuePair<int, int?> second = new KeyValuePair<int, int?>(values.Count - 1, values.Last());
            while (second.Key - first.Key > 1)
            {
                if (first.Value + second.Value == sum)
                {
                    return new KeyValuePair<KeyValuePair<int, int?>, KeyValuePair<int, int?>>(first, second);
                }
                else if (first.Value + second.Value > sum)
                {
                    var newKey = second.Key - 1;
                    second = new KeyValuePair<int, int?>(newKey, values[newKey]);
                }
                else if (first.Value + second.Value < sum)
                {
                    var newKey = first.Key + 1;
                    first = new KeyValuePair<int, int?>(newKey, values[newKey]);
                }
            }
            return NullKeyValuePair();
        }

        /// <summary>
        /// Takes a list (with no assumptions about sorting) of integers and a sum, returns the items in the list (both value and index) that equal the given sum.
        /// </summary>
        /// <param name="values">List of integers to parse</param>
        /// <param name="sum">Value of 2 summed integers from list, assumed to be positive</param>
        /// <returns>Key Value pair containing index and value of the found integers</returns>
        public static KeyValuePair<KeyValuePair<int, int?>, KeyValuePair<int, int?>> GetPairUnsorted(List<int> values, int sum)
        {
            HashSet<int> comp = new HashSet<int>();

            foreach (var item in values)
            {
                if (comp.Contains(item))
                {
                    comp.Add(sum - item);
                    return new KeyValuePair<KeyValuePair<int, int?>, KeyValuePair<int, int?>>(
                        new KeyValuePair<int, int?>(values.IndexOf(item), item),
                        new KeyValuePair<int, int?>(values.IndexOf(comp.First(x => x == (sum - item))), comp.First(x => x == (sum - item)))
                        );
                }
                comp.Add(sum - item);
            }
            return NullKeyValuePair();
        }

        private static KeyValuePair<KeyValuePair<int, int?>, KeyValuePair<int, int?>> NullKeyValuePair()
        {
            return new KeyValuePair<KeyValuePair<int, int?>, KeyValuePair<int, int?>>(
                new KeyValuePair<int, int?>(-1, null),
                new KeyValuePair<int, int?>(-1, null)
                );
        }
    }
}
