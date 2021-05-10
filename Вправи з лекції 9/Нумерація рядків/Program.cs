using System;

class Program
{
    static string[] AddNumbers(int first, params string[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = (i + first).ToString() + ". " + lines[i];
        }
        return lines;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(string.Join("\r\n", AddNumbers(1, "One", "Two", "Three")));
        Console.ReadLine();
    }
}
