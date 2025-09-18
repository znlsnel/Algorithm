using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] strlist) {
        List<int> answer = new List<int>();
        
        foreach (string str in strlist)
        {
            answer.Add(str.Length);
        }
        return answer.ToArray();
    }
}