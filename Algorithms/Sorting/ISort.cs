using System;

namespace Algorithms.Sorting
{
    public interface ISort
    {
        void Sort<T>(T[] input) where T : IComparable<T>;
    }
}