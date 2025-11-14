using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        
        
        List<int> answer = new List<int>();
        
        Array.Sort(num_list);
        for (int i = 5; i < num_list.Length; i++)
        {
            answer.Add(num_list[i]);
        }
        
        return answer.ToArray();
    }
}