using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        foreach (char c in rny_string)
        {
            if (c == 'm')
            {
                answer += "rn";
            }
            else
            {
                answer += c;
            }
        }
        return answer;
    }
}