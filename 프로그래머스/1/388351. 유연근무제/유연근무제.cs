using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int n = schedules.Length;
        int answer = 0;

        for (int i = 0; i < n; i++) {
            int hope = schedules[i];

            // 희망 출근 시각 + 10분 계산
            int hopeH = hope / 100;
            int hopeM = hope % 100;
            hopeM += 10;
            if (hopeM >= 60) {
                hopeH += 1;
                hopeM -= 60;
            }
            int limit = hopeH * 100 + hopeM;

            bool ok = true;

            for (int d = 0; d < 7; d++) {
                int day = (startday - 1 + d) % 7 + 1; // 1~7 요일

                // 토요일(6), 일요일(7)은 검사 제외
                if (day == 6 || day == 7) continue;

                int log = timelogs[i, d];

                // 지각 여부 확인
                if (log > limit) {
                    ok = false;
                    break;
                }
            }

            if (ok) answer++;
        }

        return answer;
    }
}
