using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> answer = new List<int>();
        int tn = 0;
        
        foreach (int num in num_list)
        {
            tn %= n;
            if (tn == 0)
                answer.Add(num);
            
            
            tn++;
        }
        
        return answer.ToArray();
    }
}