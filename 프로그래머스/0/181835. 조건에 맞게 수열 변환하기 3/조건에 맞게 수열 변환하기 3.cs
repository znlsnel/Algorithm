using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        List<int> answer = new List<int>();
        
        foreach (int n in arr)
        {
            answer.Add(k % 2 == 0 ? n + k : n * k);
        }
        return answer.ToArray();
    }
}