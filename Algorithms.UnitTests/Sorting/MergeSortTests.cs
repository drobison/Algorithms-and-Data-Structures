﻿using Algorithms.Sorting;
using NUnit.Framework;

namespace Algorithms.UnitTests.Sorting
{
    [TestFixture]
    public class MergeSortTests : BaseSortTests
    {
        [SetUp]
        public void Setup()
        {
            Sut = new MergeSort();
        }
    }
}
