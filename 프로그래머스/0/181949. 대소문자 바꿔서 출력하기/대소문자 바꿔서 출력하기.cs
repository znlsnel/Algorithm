using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        String answer = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z')
                answer += (char)(s[i] - 32);
            else
                answer += (char)(s[i] + 32);
                
        }
        
        Console.WriteLine(answer);
        
    }
}