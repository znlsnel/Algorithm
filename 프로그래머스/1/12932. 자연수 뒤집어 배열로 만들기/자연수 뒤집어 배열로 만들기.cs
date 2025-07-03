using System.Collections.Generic;

public class Solution 
{
    public int[] solution(long n) 
    {
        List<int> list = new List<int>();
        
        while (n > 0)
        {
            list.Add((int)(n % 10));
            n /= 10;
        }
        
        return list.ToArray();
    }
}