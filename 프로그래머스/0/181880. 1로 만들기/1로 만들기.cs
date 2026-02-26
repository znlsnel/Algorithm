using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;

        foreach (int num in num_list) {
            int current = num;
            
            // 숫자가 1이 될 때까지 반복
            while (current > 1) {
                // 짝수/홀수 구분 없이 2로 나눈 몫을 취함
                current /= 2;
                answer++;
            }
        }

        return answer;
    }
}