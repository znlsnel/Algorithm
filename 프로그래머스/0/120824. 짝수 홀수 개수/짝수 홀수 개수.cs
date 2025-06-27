using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        
        foreach (int num in num_list)
            answer[num % 2]++;
        
        return answer;
    }
}