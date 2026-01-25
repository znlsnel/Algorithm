using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;

        for (int i = left; i <= right; i++) {
            int count = 0;

            // 약수 개수 세기
            for (int j = 1; j * j <= i; j++) {
                if (i % j == 0) {
                    count++;            // j는 약수
                    if (j * j != i)     // i / j도 약수 (단, 중복 제외)
                        count++;
                }
            }

            // 짝수면 더하고, 홀수면 빼기
            if (count % 2 == 0)
                answer += i;
            else
                answer -= i;
        }

        return answer;
    }
}
