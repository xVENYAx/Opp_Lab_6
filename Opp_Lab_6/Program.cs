using System;

namespace Opp_Lab_6
{
    class Program
    {

        static void sort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        // Prints the array
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введiть розмiрнiсть масиву: ");
                var n = Console.ReadLine();
                int N = int.Parse(n);
                int[] array = new int[N];
                var rand = new Random();
                for (var i = 0; i < array.Length; i++)
                    array[i] = rand.Next(0, 101);
                Console.Write("Згенерований масив: ");
                foreach (var a in array)
                {
                    Console.Write(a + " ");
                }
                Console.Write("\n");
                sort(array);
                Console.Write("Сортований масив методом СocktailSort: ");
                printArray(array);
                Console.ReadKey();
            }
            
            catch
            {
                Console.WriteLine("Error! Ви не вели число, або не вели ціле число!");
                Console.WriteLine("Ведіть знову число.");
                Console.WriteLine();

                Console.WriteLine("Введiть розмiрнiсть масиву: ");
                var n = Console.ReadLine();
                int N = int.Parse(n);
                int[] array = new int[N];
                var rand = new Random();
                for (var i = 0; i < array.Length; i++)
                    array[i] = rand.Next(0, 101);
                Console.Write("Згенерований масив: ");
                foreach (var a in array)
                {
                    Console.Write(a + " ");
                }
                Console.Write("\n");
                sort(array);
                Console.Write("Сортований масив методом СocktailSort: ");
                printArray(array);
                Console.ReadKey();
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("End program.");
            }
            }
    }
}

