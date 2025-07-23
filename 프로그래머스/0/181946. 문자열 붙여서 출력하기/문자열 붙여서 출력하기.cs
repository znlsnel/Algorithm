using System;

public class Example
{
    public static void Main()
    {
        string[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        string s1 = input[0];
        string s2 = input[1];
        
        Console.WriteLine(s1+s2);
    }
}