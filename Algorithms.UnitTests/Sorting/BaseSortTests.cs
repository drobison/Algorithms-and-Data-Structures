using Algorithms.Sorting;
using NUnit.Framework;

namespace Algorithms.UnitTests.Sorting
{
    public abstract class BaseSortTests
    {
        protected ISort Sut;


        [Test]
        public void Sort_Empty()
        {
            var input = new int[0];
            Sut.Sort(input);
        }

        [Test]
        public void Sort_OutOfOrder()
        {
            var input = new int[] { 5, 1, 3, 2, 4 };
            Sut.Sort(input);
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, input);
        }

        [Test]
        public void Sort_Preordered()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            Sut.Sort(input);
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, input);
        }
    }
}