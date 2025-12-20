using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";

        foreach (char c in myString)
        {
            if (c == 'a') 
            {
                answer += 'A';
            }
            else if (c >= 'A' && c <= 'Z' && c != 'A')
            {
                answer += Char.ToLower(c);
            }
            else
            {
                answer += c;
            }
        }

        return answer;
    }
}
