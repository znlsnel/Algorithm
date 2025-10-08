using System;

public class Solution {
    public int solution(int a, int b) {
        int answerA = a;
        int answerB = b;
        
        int ta = a;
        int tb = b;
        
        while (tb > 0)
        {
            answerA *= 10;
            tb /= 10;
        }
        answerA += b;
        
        while (ta > 0)
        {
            answerB *= 10;
            ta /= 10;
        }
        answerB += a;
        
        
        return Math.Max(answerA, answerB);
    }
}