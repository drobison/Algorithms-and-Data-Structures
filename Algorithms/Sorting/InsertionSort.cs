using System;

namespace Algorithms.Sorting
{
    public class InsertionSort : ISort
    {
        public void Sort<T>(T[] input) where T : IComparable<T>
        {
            
            for (int j = 1; j < input.Length; j++)
            {
                var key = input[j];
                var i = j - 1;
                while (i >= 0 && input[i].CompareTo(key) > 0)
                {
                    input[i + 1] = input[i];
                    i--;
                }

                input[i + 1] = key;
            }
        }
    }
}
