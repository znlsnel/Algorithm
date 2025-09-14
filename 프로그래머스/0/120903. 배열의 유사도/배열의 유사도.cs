using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        
        foreach (string c1 in s1)
        {
            foreach (string c2 in s2)
            {
                if (c1 == c2)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}