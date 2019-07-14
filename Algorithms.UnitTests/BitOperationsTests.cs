using System;
using NUnit.Framework;

namespace Algorithms.UnitTests
{
    [TestFixture]
    public class BitOperationsTests
    {
        [Test]
        public void AndTests()
        {
            BitOperations.And(3, 5);
        }

        [Test]
        public void OrTests()
        {
            BitOperations.Or(25, 7);
        }

        [Test]
        public void XorTests()
        {
            BitOperations.Xor(25, 7);
        }

        [Test]
        public void NotTests()
        {
            BitOperations.Not(25);
        }

        [Test]
        public void ShiftLeftTests()
        {
            BitOperations.ShiftLeft(1073741824);
        }

        [Test]
        public void ShiftRightTests()
        {
            BitOperations.ShiftRight(Int32.MaxValue);
        }

        [Test]
        public void ToggleBoolTests()
        {
            Assert.AreEqual(false, BitOperations.ToggleBool(true));
            Assert.AreEqual(true, BitOperations.ToggleBool(false));
        }

        [Test]
        public void EnumFlagsTests()
        {
            BitOperations.EnumFlags();
        }

        [Test]
        public void MaskingTests()
        {
            BitOperations.Masking();
        }

        [TestCase(6, 2)]
        [TestCase(0, 0)]
        public void CountBitsTest(int input, int expectedResult)
        {
            var result = BitOperations.CountBits(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
