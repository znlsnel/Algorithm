using System;


public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            answer += i;
        
        return answer;
    }
}