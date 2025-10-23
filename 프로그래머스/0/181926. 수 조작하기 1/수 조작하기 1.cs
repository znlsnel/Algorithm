using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;
        
        foreach (char c in control)
        {
            if (c == 'w')
            {
                answer += 1;
            }
            else if (c == 's')
            {
                answer -= 1;
            }
            else if (c == 'd')
            {
                answer += 10;
            }
            else if (c == 'a')
            {
                answer -= 10;
            }
        }
        return answer;
    }
}