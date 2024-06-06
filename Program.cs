
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


    }
}
