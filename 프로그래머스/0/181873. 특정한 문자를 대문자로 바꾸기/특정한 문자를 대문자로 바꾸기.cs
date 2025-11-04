using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        foreach (char c in my_string)
        {
            char cr = c;
            if (alp.Contains(c))
            {
                cr = (char)(c - ('a' - 'A'));
            }
            answer += cr;
        }
        return answer;
    }
}