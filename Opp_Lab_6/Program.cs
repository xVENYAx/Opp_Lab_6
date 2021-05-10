using System;

namespace Opp_Lab_6
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Ведіть 10 чисел, після кожного числа нажимайте enter:");
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
            int[] arr = new int[10] { k, q, w, e, r, t, y, u, f, o};
            int n = 10;
            Console.WriteLine("Selection sort");
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
    }
}

