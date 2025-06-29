using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach (char c in my_string)
            answer = c + answer;
        return answer;
    }
}