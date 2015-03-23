using System;
using System.Collections.Generic;

namespace task2
{
    public class CountSorter : ISorter
    {
        public virtual List<int> sort(List<int> numbers)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            int maxKey = 0;

            foreach (int n in numbers) {
                if (counter.ContainsKey(n))
                    counter[n]++;
                else
                    counter[n] = 1;

                if (maxKey == 0 || n > maxKey) {
                    maxKey = n;
                }
            }

            List<int> res = new List<int>();

            for (int n = 0; n < maxKey; n++) {
                if (!counter.ContainsKey(n))
                    continue;

                for (int i = 0; i < counter[n]; i++) {
                    res.Add(n);
                }
            }

            return res;
        }
    }
}

