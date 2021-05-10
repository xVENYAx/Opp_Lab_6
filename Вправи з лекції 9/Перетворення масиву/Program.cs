using System;

class Program
{
    static float[] Mult(float k, params float[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 0)
            {
                a[i] *= k;
            }
        }
        return a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ", Mult(-2, -7, -3, 0, 7, 9, 11)));
        Console.ReadLine();
    }
}
