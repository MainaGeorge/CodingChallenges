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

        //Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200
        public static bool IsWithin10Of100Or200(int n)
        {
            return (n >= 90 && n <= 110) || (n >= 190 && n <= 210);
        }

        //Write a C# Sharp program to remove the character in a given position of a given string.
        //The given position will be in the range 0.. string length -1 inclusive
        public static string RemoveAtIndex(string input, int index)
        {
            if (index == input.Length)
                return input[0..^2];

            return input[0..index] + input[(index + 1)..];
        }

        //Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
        public static bool IsAMultipleOf3Or7(int n) => n > 0 && (n % 3 == 0 || n % 7 == 0);
    }
}