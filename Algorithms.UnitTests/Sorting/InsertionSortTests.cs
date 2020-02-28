using Algorithms.Sorting;
using NUnit.Framework;

namespace Algorithms.UnitTests.Sorting
{
    [TestFixture]
    public class InsertionSortTests : BaseSortTests
    {
        [SetUp]
        public void Setup()
        {
            Sut = new InsertionSort();
        }
    }
}