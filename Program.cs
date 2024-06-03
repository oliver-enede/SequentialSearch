using System;

namespace SequentialSearch
{
    internal class Program
    {
        public static int SequentialSearch(int[] arr, int size, int value)
        {
            // Iterate through the array to find the value
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    return i; // Return the index of the found value
                }
            }
            return -1; // Return -1 if the value is not found
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int valueToFind = 5;

            int index = SequentialSearch(arr, arr.Length, valueToFind);

            if (index != -1)
            {
                Console.WriteLine($"Value {valueToFind} found at index: {index}");
            }
            else
            {
                Console.WriteLine($"Value {valueToFind} not found in the array.");
            }

            Console.ReadLine();
        }
    }
}