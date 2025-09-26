using System;

public class Solution {
    public string solution(string myString) 
    {
        string answer = "";
        foreach (char c in myString)
        {
            char t = c;
            if (c >= 'a' && c <= 'z')
            {
                t = (char)(c - 32);
            }
            answer += t;
        }
        return answer;
    }
}