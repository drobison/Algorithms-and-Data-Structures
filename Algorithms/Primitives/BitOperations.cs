using System;

namespace Algorithms.Primitives
{
    public class BitOperations
    {
        public static void And(int first, int second)
        {

            var result = first & second;

            PrintResults(first, second, result);
        }

        public static void Or(int first, int second)
        {

            var result = first | second;

            PrintResults(first, second, result);
        }

        public static void Xor(int first, int second)
        {

            var result = first ^ second;

            PrintResults(first, second, result);
        }

        public static void Not(int first)
        {

            var result = (byte) ~first;

            PrintResults(first, result);
        }

        public static void ShiftLeft(int first)
        {
            var result = (byte) first << 1;

            PrintResults(first, result);
        }

        public static void ShiftRight(int first)
        {
            var result = (byte)first >> 1;

            PrintResults(first, result);
        }


        public static string ConvertToBinaryString(int result)
        {
            return ($"{Convert.ToString(result, 2).PadLeft(31, '0')}");
        }

        private static void PrintResults(int first, int second, int result)
        {
            Console.WriteLine(ConvertToBinaryString(first));
            Console.WriteLine(ConvertToBinaryString(second));
            Console.WriteLine("------");
            Console.WriteLine(ConvertToBinaryString(result));
        }

        private static void PrintResults(int first, int result)
        {
            Console.WriteLine(ConvertToBinaryString(first));
            Console.WriteLine("------");
            Console.WriteLine(ConvertToBinaryString(result));
        }

        public static bool ToggleBool(bool value)
        {
            value ^= true;
            return value;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/csharp-program-for-count-set-bits-in-an-integer/
        /// EPI pg. 44
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int CountBits(int x)
        {
            int numBits = 0;
            while (x != 0)
            {
                Console.WriteLine(ConvertToBinaryString(x));
                numBits += (x & 1);
                x >>= 1;

            }

            return numBits;
        }

        public static Int64 ParityOfWord(int x)
        {
            Int64 result = 0;
            while (x != 0)
            {
                Console.WriteLine("Current value of input:");
                Console.WriteLine(ConvertToBinaryString(x));
                var resultANd = x & 1;
                Console.WriteLine("Anding input with 1:");
                Console.WriteLine(resultANd);

                result ^= x & 1;

                Console.WriteLine("xorered with result");

                Console.WriteLine("current value of result:");
                Console.WriteLine(result);

                x >>= 1;
            }
            Console.WriteLine("Final parity value");
            Console.WriteLine(ConvertToBinaryString(x));


            return result;

        }

        public static int LowestSetBitErased(int x)
        {
            Console.WriteLine(ConvertToBinaryString(x));
            x &= (x - 1);
            Console.WriteLine(ConvertToBinaryString(x));
            return x;
        }

        public static int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }

            return a;
        }

        public static int SetBit(int n, int position)
        {
            var mask = 1 << position;
            return n | mask;
        }

        public static int ClearBit(int n, int position)
        {
            var mask = ~(1 << position);
            return n & mask;
        }

        public static int ClearBitsSBToI(int n, int position)
        {
            Console.WriteLine(ConvertToBinaryString(n));
            var mask = (1 << position) - 1;
            Console.WriteLine(ConvertToBinaryString(mask));

            return n & mask;
        }

        public static int ClearBitsZeroToI(int n, int position)
        {
            Console.WriteLine(ConvertToBinaryString(n));
            var mask = -1 << (position + 1);
            Console.WriteLine(ConvertToBinaryString(mask));

            return n & mask;
        }

        /// <summary>
        /// CTCI 5.1
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>

        public static int InsertNumber(int n, int m, int i, int j)
        {
            var maskRight = (1 << j) - 1; //flips bits on right to 1 -  00000111
            Console.WriteLine(ConvertToBinaryString(maskRight));
            var maskLeft = -1 << (i + 1); // flips bits on right to 0 - 11110000 
            Console.WriteLine(ConvertToBinaryString(maskLeft));

            var mask = (maskLeft | maskRight);
            Console.WriteLine(ConvertToBinaryString(mask));

            n = n & mask;
            m = m << i;
            Console.WriteLine(ConvertToBinaryString(m));

            return n | m;
        }

        public static int IsolateLowestSetBit(int x)
        {
            Console.WriteLine(ConvertToBinaryString(x));
            x &= ~(x - 1);
            Console.WriteLine(ConvertToBinaryString(x));
            return x;
        }

        public static void EnumFlags()
        {
            // setting one value
            var colors = Colors.Blue;
            Console.WriteLine(ConvertToBinaryString((byte)colors));

            // setting multiple enums at once
            colors = Colors.Blue | Colors.White;
            Console.WriteLine(ConvertToBinaryString((byte)colors));

            // validating a particular enum has been set
            if ((colors & Colors.Blue) == Colors.Blue)
            {
                // we have blue
                Console.WriteLine("Contains blue");
            }
        }

        public static void Masking()
        {
            // 0011100 Input
            // 0000100 Important bit
            // 0000100 Result
            var input = Colors.Blue;
            var mask = Colors.White;
            var result = input & mask;
        }

        
        [Flags]
        public enum Colors
        {
            Red = 1,
            Blue = 2,
            Green = 4,
            Black = 8,
            White = 16,
            Orange = 32,
            Yellow = 64,
            Pink = 128
        }
    }
}
