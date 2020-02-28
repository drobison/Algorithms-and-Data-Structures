using System;

namespace Algorithms.Sorting
{
    public class MergeSort : ISort
    {
        public void Sort<T>(T[] a) where T : IComparable<T>
        {
            Sort(a, 0, a.Length);
        }

        public void Sort<T>(T[] a, int low, int high) where T : IComparable<T>
        {
            int searchSize = high - low;

            if (searchSize <= 1)
                return;

            int mid = (searchSize / 2) + low;

            // recurse sort left
            Sort(a, low, mid);
            // recurse sort right
            Sort(a, mid, high);

            // Merge
            T[] aux = new T[searchSize];
            int left = low;
            int right = mid;

            for (int k = 0; k < searchSize; k++)
            {
                // Check to see if we have exhausted either side, if so only grab from the other
                if (left == mid)
                    aux[k] = a[right++];
                else if (right == high)
                    aux[k] = a[left++];
                // both sides in play, compare to see which comes next
                else if (a[left].CompareTo(a[right]) < 0)
                    aux[k] = a[left++];
                else
                    aux[k] = a[right++];
            }

            // move values from aux array, back into list
            for (int k = 0; k < searchSize; k++)
            {
                a[low + k] = aux[k];
            }
        }
    }

}
