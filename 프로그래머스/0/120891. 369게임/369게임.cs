using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        
        while (order > 0)
        {
            int v = order % 10;
            if (v == 3 || v == 6 || v == 9)
                answer++;
            
            order /= 10;
        }
        return answer;
    }
}