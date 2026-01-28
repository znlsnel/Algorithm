using System;

public class Example
{
    public static void Main()
    {
        String[] s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]); // 가로
        int m = Int32.Parse(s[1]); // 세로

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(new string('*', n));
        }
    }
}
