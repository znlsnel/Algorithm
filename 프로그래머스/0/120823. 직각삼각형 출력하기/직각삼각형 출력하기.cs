using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);

        for (int i = 1; i <= n; i++)
        {
            int cnt = i;
            while (cnt-- > 0)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}