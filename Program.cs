using System;

namespace TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = {1,2,3,4,5,6,};
            int targetValue = 10;

            // Positive Test - Should out put 4, 6
            TwoNumberSum(testArray, targetValue);

            // Negative Test - Should output Negative assertion and empty array
            int[] secondArray = {2,3,5,6};
            int secondTarget = 23;
            TwoNumberSum(secondArray, secondTarget);
        }
        public static int[] TwoNumberSum(int[] arr, int target)
        {
            // Iterate throug the array using nested For loop
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // Evaluate
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"There are values that equal the sum: {arr[i]} , {arr[j]}");
                        return new int[] {arr[i], arr[j]};
                    }
                }
            }
            Console.WriteLine("There are no values in the array that equal the target");
            return new int[0];
        }
    }
}
