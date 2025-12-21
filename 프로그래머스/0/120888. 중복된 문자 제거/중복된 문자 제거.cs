using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in my_string)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                answer += c;
            }
        }

        return answer;
    }
}
