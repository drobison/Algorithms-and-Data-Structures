using System;
using Algorithms.Primitives;
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

        [Test]
        public void LowestSetBitErasedTests()
        {
            var result = BitOperations.LowestSetBitErased(44);
        }

        [Test]
        public void IsolateLowestSetBitTests()
        {
            var result = BitOperations.IsolateLowestSetBit(44);
        }

        [Test]
        public void SetABit()
        {
            var result = BitOperations.SetBit(0,5);
            Console.WriteLine(Convert.ToString(result, toBase: 2));
        }

        [Test]
        public void ClearABit()
        {
            var result = BitOperations.SetBit(0, 5);
            result = BitOperations.ClearBit(0, 5);
            Console.WriteLine(Convert.ToString(result, toBase: 2));
        }

        [Test]
        public void ClearBitsSBToI()
        {
            var input = 142;
            var result = BitOperations.ClearBitsSBToI(input, 5);
            Console.WriteLine(Convert.ToString(result, toBase: 2));
        }

        [Test]
        public void ClearBitsZeroToI()
        {
            var input = 142;
            var result = BitOperations.ClearBitsZeroToI(input, 2);
            Console.WriteLine(Convert.ToString(result, toBase: 2));
        }

        [Test]
        public void InsertNumber()
        {
            var n = 1024;
            var m = 19;
            var i = 2;
            var j = 6;

            var result = BitOperations.InsertNumber(n, m,i, j);
            Console.WriteLine(Convert.ToString(result, toBase: 2));
        }

        [TestCase(6, 2)]
        [TestCase(0, 0)]
        public void CountBitsTest(int input, int expectedResult)
        {
            var result = BitOperations.CountBits(input);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2,1)]
        [TestCase(3,0)]
        [TestCase(276, 1)]
        public void ParityCheck(int input, int expectedResult)
        {
            var result = BitOperations.ParityOfWord(input);
            Assert.True(result % 2 == expectedResult);
        }
    }
}
