using System;
using System.Diagnostics;

namespace SearchAlgorithms
{

    public class SearchAlgorithm
    {
        public static int LinearSearch(int[] array, int target, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch(int[] array, int target, int left, int right)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }

    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] array = new int[1000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
            }

            Console.WriteLine("LinearSearch:");
            for (int n = 10; n <= array.Length; n *= 2)
            {
                int target = random.Next(1000);
                Stopwatch stopwatch = Stopwatch.StartNew();
                int index = SearchAlgorithm.LinearSearch(array, target, n);
                stopwatch.Stop();
                Console.WriteLine("n = {0}, time taken = {1} ms", n, stopwatch.ElapsedTicks);
            }

            Console.WriteLine("BinarySearch:");
            for (int n = 10; n <= array.Length; n *= 2)
            {
                Array.Sort(array, 0, n);
                int target = array[random.Next(n)];
                Stopwatch stopwatch = Stopwatch.StartNew();
                int index = SearchAlgorithm.BinarySearch(array, target, 0, n - 1);
                stopwatch.Stop();
                Console.WriteLine("n = {0}, time taken = {1} ms", n, stopwatch.ElapsedTicks);
            }
        }
    }

}


