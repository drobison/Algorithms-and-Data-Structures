using System;
using NUnit.Framework;

namespace Algorithms.UnitTests.Sorting
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void Sort_Empty()
        {
            var input = new int[0];
            Algorithms.Sorting.Sorting.MergeSort(input);
        }

        [Test]
        public void Sort_OutOfOrder()
        {
            var input = new int[] { 5, 1, 3, 2, 4 };
            Algorithms.Sorting.Sorting.MergeSort(input);
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, input);
        }

        [Test]
        public void Sort_Preordered()
        {
            var input = new int[] {1, 2, 3, 4, 5};
            Algorithms.Sorting.Sorting.MergeSort(input);
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, input);
        }
    }
}
