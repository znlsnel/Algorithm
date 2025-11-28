using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        List<string> list = new List<string>();
        foreach (string st in strArr)
        {
            if(!st.Contains("ad"))
                   list.Add(st);        
        }
        return list.ToArray();
    }
}