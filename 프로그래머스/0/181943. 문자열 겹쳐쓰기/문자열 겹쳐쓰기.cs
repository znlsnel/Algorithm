using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        
        int idx = 0;
        string answer = "";
        
        for (int i = 0; i < my_string.Length; i++)
        {
            if (i >= s && i < s + overwrite_string.Length)
                answer += overwrite_string[idx++];
            else
                answer += my_string[i];
        }
        return answer;
    }
}