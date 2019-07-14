using System;

namespace Algorithms
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


        private static string ConvertToBinaryString(int result)
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
