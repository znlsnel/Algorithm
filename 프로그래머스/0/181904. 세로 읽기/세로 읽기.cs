using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        
        int idx = c-1;
        while (idx < my_string.Length)
        {
         answer += my_string[idx];
            idx += m;
        }
        
        return answer;
    }
}