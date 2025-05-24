using System;

public class Solution 
{
    public int solution(int n) 
    {
        string a = n.ToString();
        
        int answer = 0;
        
        foreach (char c in a)
        {
            answer += c - '0';
        }
        return answer;
    }
}