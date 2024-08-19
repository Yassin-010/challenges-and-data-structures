using System;
using System.Collections.Generic;

namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 1, 2, 3 };
            int[] duplicates1 = FindDuplicates(input1);


            Console.WriteLine("Input: [1, 2, 3, 1, 2, 3]");
            Console.WriteLine("Output: [" + string.Join(", ", duplicates1) + "]");
            Console.WriteLine();

            int[] input2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] duplicates2 = FindDuplicates(input2);
            Console.WriteLine("Input: [16, 8, 31, 17, 15, 23, 17, 8]");
            Console.WriteLine("Output: [" + string.Join(", ", duplicates2) + "]");
            Console.WriteLine();

            int[] input3 = { 5, 10, 16, 20, 10, 16 };
            int[] duplicates3 = FindDuplicates(input3);
            Console.WriteLine("Input: [5, 10, 16, 20, 10, 16]");
            Console.WriteLine("Output: [" + string.Join(", ", duplicates3) + "]");
            Console.WriteLine();
        }

        public static int[] FindDuplicates(int[] arr)


        {
            List<int> duplicates = new List<int>();
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach(int num in arr)
            {
                if(countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }


            foreach(KeyValuePair<int, int> entry in countMap)
            {
                if(entry.Value > 1)
                    duplicates.Add(entry.Key);
            }

            return duplicates.ToArray();
        }
    }
}