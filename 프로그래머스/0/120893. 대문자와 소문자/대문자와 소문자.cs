using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        foreach (char a in my_string)
        {
            answer = answer + (a >= 'A' && a <= 'Z' ? 
                               (char)(a + ('a' - 'A')) : 
                               (char)(a - ('a' - 'A')));
        }
        return answer;
    }
}