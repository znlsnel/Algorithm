using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> answer = arr.ToList();
        
        foreach (int n in delete_list)
        {
            answer.Remove(n);
        }
        
        return answer.ToArray();
    }
}