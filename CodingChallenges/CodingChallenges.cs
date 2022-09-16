using System.ComponentModel;

namespace CodingChallenges
{
    public static class CodingChallenges
    {
        //Write a C# Sharp program to compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum
        public static int SumOrTripleSumOf2Numbers(int a, int b)
        {
            return a == b ? (a + b) * 3 : (a + b);
        }

        //Write a C# Sharp program to get the absolute difference between n and 51.
        //If n is greater than 51 return triple the absolute difference
        public static int AbsoluteDifference(int input)
        {
            return input > 51 ? (input - 51) * 3 : 51 - input;
        }

        //Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30
        public static bool Is30OrSumsTo30(int a, int b)
        {
            return a == 30 || b == 30 || (a + b) == 30;
        }
    }
}