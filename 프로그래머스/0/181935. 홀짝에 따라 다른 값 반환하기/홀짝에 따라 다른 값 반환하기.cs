using System;

public class Solution {
    public int solution(int n) 
    {
        int answerA = 0;
        int answerB = 0;
        
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                answerA += i * i;
            else
                answerB += i;
        }
        return n % 2 == 0 ? answerA : answerB;
    }
}