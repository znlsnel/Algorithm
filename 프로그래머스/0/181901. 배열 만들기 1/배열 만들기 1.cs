using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        List<int> answer = new List<int>();
        for (int i = k; i <= n; i += k)
        {
            answer.Add(i);
        }
        return answer.ToArray();
    }
}