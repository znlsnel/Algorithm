using System;

public class Solution {
    public int solution(int n) {
        // 1. n을 3진법으로 직접 변환 (뒤집힌 상태로 저장)
        string reversed = "";
        while (n > 0) {
            reversed += (n % 3).ToString();
            n /= 3;
        }

        // 2. 뒤집힌 3진법 문자열을 10진법으로 변환
        int answer = 0;
        int power = 1;

        for (int i = reversed.Length - 1; i >= 0; i--) {
            answer += (reversed[i] - '0') * power;
            power *= 3;
        }

        return answer;
    }
}
