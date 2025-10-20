using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int n = num_list.Length;
        List<int> answer = new List<int>();
        foreach (int num in num_list)
        {
            answer.Add(num);
        }
        
        if (answer[n-1] > answer[n-2])
            answer.Add(answer[n-1] - answer[n-2]);
        else
            answer.Add(answer[n-1]*2);
        
        
        return answer.ToArray();
    }
}