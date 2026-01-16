 using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        
        for (int i = 0; i < absolutes.Length; i++) {
            // signs[i]가 true면 양수, false면 음수
            answer += signs[i] ? absolutes[i] : -absolutes[i];
        }
        
        return answer;
    }
}
