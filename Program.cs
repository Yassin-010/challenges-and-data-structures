﻿
namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Orginal arry:");
            PrintArray(array);

            int[] reversedArray = ArrayReversal(array);

            Console.WriteLine("Reversed array:");
            PrintArray(reversedArray);


            // Problem 2
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            int mostFrequent = MostFrequentNumber(numbers);

            Console.WriteLine("Most frequent number: " + mostFrequent);


            Console.WriteLine();
            // Problem 3 
            int[] arr1 = { 10, 15, 8, 6, 12 };
            int[] arr2 = { 1, 3, 5, 7, 9 };
            int[] arr3 = { 7, 9, 13, 25, 5 };
            Console.WriteLine("The arr1 contains : 10, 15, 8, 6, 12");
            Console.WriteLine("The arr2 contains : 1, 3, 5, 7, 9");
            Console.WriteLine("The arr3 contains : 7, 9, 13, 25, 5");


            int max1 = MaximumValue(arr1);
            int max2 = MaximumValue(arr2);
            int max3 = MaximumValue(arr3);

            Console.WriteLine("Maximum value in arr1: " + max1);
            Console.WriteLine("Maximum value in arr2: " + max2);
            Console.WriteLine("Maximum value in arr3: " + max3);

        }

        static int MostFrequentNumber(int[] arr)
        {

            Dictionary<int, int> frequencyCount = new Dictionary<int, int>();

            foreach(int num in arr)
            {
                if(frequencyCount.ContainsKey(num))
                    frequencyCount[num]++;
                else
                    frequencyCount[num] = 1;
            }

            int mostFrequentNumber = arr[0];
            int maxFrequency = frequencyCount[arr[0]];

            foreach(var kvp in frequencyCount)
            {
                if(kvp.Value > maxFrequency)
                {
                    mostFrequentNumber = kvp.Key;
                    maxFrequency = kvp.Value;
                }
            }

            return mostFrequentNumber;
        }


        static int[] ArrayReversal(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end)
            {
                reversedArray[start] = arr[end];
                reversedArray[end] = arr[start];

                start++;
                end--;
            }
            return reversedArray;
        }

        static void PrintArray(int[] arr)
        {
            foreach(int num in arr)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();
        }
        static int MaximumValue(int[] arr)
        {
            int maxVal = int.MinValue; // Initialize maxVal to the minimum possible value of an integer

            foreach(int num in arr)
            {
                if(num > maxVal)
                {
                    maxVal = num;
                }
            }

            return maxVal;
        }




    }
}
