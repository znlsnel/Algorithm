using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        foreach (char c in my_string)
        {
            if (c >= '0' && c <= '9')
                answer += ((int)(c - '0'));
        }
        return answer;
    }
}