using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        foreach (char c in myString)
        {
            char t = c;
            if (t >= 'A' && t <= 'Z')
                t = (char)(c + ('a' - 'A'));
            answer += t;
        }
        return answer;
    }
}