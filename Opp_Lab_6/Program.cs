using System;

namespace Opp_Lab_6
{
    class Program
    {



        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ведіть 10 цілих чисел, після кожного числа нажимайте enter:");
                int k = Convert.ToInt32(Console.ReadLine());
                int q = Convert.ToInt32(Console.ReadLine());
                int w = Convert.ToInt32(Console.ReadLine());
                int e = Convert.ToInt32(Console.ReadLine());
                int r = Convert.ToInt32(Console.ReadLine());
                int t = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int u = Convert.ToInt32(Console.ReadLine());
                int f = Convert.ToInt32(Console.ReadLine());
                int o = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[10] { k, q, w, e, r, t, y, u, f, o };
                int n = 10;
                Console.WriteLine();
                Console.WriteLine("Selection sort");
                Console.WriteLine();
                Console.Write("Initial array is: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                int temp, smallest;
                for (int i = 0; i < n - 1; i++)
                {
                    smallest = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < arr[smallest])
                        {
                            smallest = j;
                        }
                    }
                    temp = arr[smallest];
                    arr[smallest] = arr[i];
                    arr[i] = temp;
                }
                Console.WriteLine();
                Console.Write("Sorted array is: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            
            catch
            {
                Console.WriteLine("Error! Ви не вели число, або не вели ціле число!");
                Console.WriteLine("Ведіть знову число.");
                Console.WriteLine();

                Console.WriteLine("Ведіть 10 цілих чисел, після кожного числа нажимайте enter:");
                int k = Convert.ToInt32(Console.ReadLine());
                int q = Convert.ToInt32(Console.ReadLine());
                int w = Convert.ToInt32(Console.ReadLine());
                int e = Convert.ToInt32(Console.ReadLine());
                int r = Convert.ToInt32(Console.ReadLine());
                int t = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int u = Convert.ToInt32(Console.ReadLine());
                int f = Convert.ToInt32(Console.ReadLine());
                int o = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[10] { k, q, w, e, r, t, y, u, f, o };
                int n = 10;
                Console.WriteLine();
                Console.WriteLine("Selection sort");
                Console.WriteLine();
                Console.Write("Initial array is: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                int temp, smallest;
                for (int i = 0; i < n - 1; i++)
                {
                    smallest = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < arr[smallest])
                        {
                            smallest = j;
                        }
                    }
                    temp = arr[smallest];
                    arr[smallest] = arr[i];
                    arr[i] = temp;
                }
                Console.WriteLine();
                Console.Write("Sorted array is: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("End program.");
            }
            }
    }
}

