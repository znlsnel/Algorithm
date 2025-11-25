using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;
        if (my_string.Length < is_suffix.Length)
            return 0;
        
        int idx = my_string.Length - 1;
        for (int i = is_suffix.Length-1; i >= 0; i--)
        {
            if (is_suffix[i] != my_string[idx--])
                return 0;
        }
        return 1;
    }
}