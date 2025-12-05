using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        bool left = false;
        
        int idx = 0;
        
        foreach (string str in str_list)
        {
            
            if (str == "l")
            {
                left = true;
                break;
            }
            else if (str == "r")
            {
                left = false;
                break;
            }
            idx++;
        }
        List<string> answer = new List<string>();
        
        if (left)
        {
            for (int i = 0; i < idx; i++)
                answer.Add(str_list[i]);
        }
        else
        {
            for (int i = idx+1; i < str_list.Length; i++)
                answer.Add(str_list[i]);
        }
        return answer.ToArray();
    }
}