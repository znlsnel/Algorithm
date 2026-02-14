using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int paintedUntil = 0; // 현재까지 칠해진 마지막 구역 번호

        foreach (int pos in section)
        {
            // 아직 칠해지지 않은 구역을 만나면 새로 칠해야 함
            if (pos > paintedUntil)
            {
                answer++;
                paintedUntil = pos + m - 1; // 이번에 칠해지는 마지막 구역
            }
        }

        return answer;
    }
}
