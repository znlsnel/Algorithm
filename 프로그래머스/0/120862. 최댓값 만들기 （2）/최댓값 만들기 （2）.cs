using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        
        int answer = -1000000000;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                answer = Math.Max(answer, numbers[i] * numbers[j]);
            }
        }
        return answer;
    }
}