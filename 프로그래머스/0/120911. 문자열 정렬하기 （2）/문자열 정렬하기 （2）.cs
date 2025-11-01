using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        List<int> list = new List<int>();
        foreach (char c in my_string)
        {
            int n = (int)c;
            if (c >= 'A' && c <= 'Z')
            {
                n +=  'a' - 'A';
            }
            list.Add(n);
        }
        
        list.Sort();
        
        string answer = "";
        
        foreach (int n in list)
        {
            answer = answer + (char)n;
        }
        
        return answer;
    }
}