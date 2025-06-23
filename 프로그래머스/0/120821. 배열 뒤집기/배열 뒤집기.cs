using System;

public class Solution {
    public int[] solution(int[] list) {
        int[] answer = new int[list.Length];
        
        int idx = 0;
        for (int i = list.Length-1; i >= 0; i--)
            answer[idx++] = list[i];
        
        return answer;
    }
}