using System;

class Program
{
    static int[] Sqr(params int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
            nums[i] *= nums[i];
        return nums;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ", Sqr(1, 2, 3, 4, 5, 6)));
        Console.ReadLine();
    }
}
