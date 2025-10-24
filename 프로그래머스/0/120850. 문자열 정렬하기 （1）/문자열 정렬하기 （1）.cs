using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        List<int> answer = new List<int>();
        foreach (char c in my_string)
        {
            if (c >= '0' && c <= '9')
                answer.Add((int)(c - '0'));
        }
        answer.Sort();
        return answer.ToArray();
    }
}