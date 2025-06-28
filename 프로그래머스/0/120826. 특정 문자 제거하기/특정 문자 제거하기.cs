using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        foreach (var c in my_string)
            if (c != letter[0])
                answer += c;
        
        return answer;
    }
}