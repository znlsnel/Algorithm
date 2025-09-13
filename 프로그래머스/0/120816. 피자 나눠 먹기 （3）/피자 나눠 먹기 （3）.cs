using System;

public class Solution 
{
    public int solution(int slice, int n) 
    {
        int answer = 0;
        
        if (slice >= n)
            return 1;
        
        return n / slice + (n % slice > 0 ? 1 : 0);
    }
}