using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;

        for (int i = 1; i <= n; i++) {
            int count = 0;

            // i의 약수 개수 세기
            for (int j = 1; j <= i; j++) {
                if (i % j == 0) count++;
            }

            // 약수 개수가 3개 이상이면 합성수
            if (count >= 3) answer++;
        }

        return answer;
    }
}
