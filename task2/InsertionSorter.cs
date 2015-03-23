using System;
using System.Collections.Generic;

namespace task2
{
    public class InsertionSorter : ISorter
    {
        public virtual List<int> sort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++) {
                for (int t = 0; t < numbers.Count; t++) {
                    if (numbers[i] < numbers[t]) {
                        int tmp = numbers[t];
                        numbers[t] = numbers[i];
                        numbers[i] = tmp;
                    }
                }
            }

            return numbers;
        }
    }
}

