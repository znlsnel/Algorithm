using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[,] q, int[] ans) {
        int answer = 0;
        int m = q.GetLength(0);

        // 5중 반복문으로 모든 조합 생성 (1 ~ n)
        for (int i = 1; i <= n - 4; i++) {
            for (int j = i + 1; j <= n - 3; j++) {
                for (int k = j + 1; k <= n - 2; k++) {
                    for (int l = k + 1; l <= n - 1; l++) {
                        for (int p = l + 1; p <= n; p++) {
                            
                            // 현재 생성된 조합: {i, j, k, l, p}
                            int[] currentCombo = { i, j, k, l, p };
                            
                            if (IsValid(currentCombo, q, ans, m)) {
                                answer++;
                            }
                        }
                    }
                }
            }
        }

        return answer;
    }

    // 해당 조합이 모든 힌트를 만족하는지 체크하는 함수
    private bool IsValid(int[] combo, int[,] q, int[] ans, int m) {
        for (int i = 0; i < m; i++) {
            int matchCount = 0;
            
            // 시도했던 5개의 숫자 중 몇 개가 현재 조합에 들어있는지 확인
            for (int j = 0; j < 5; j++) {
                int target = q[i, j];
                // combo는 정렬되어 있으므로 Array.BinarySearch를 쓰면 더 빠르지만,
                // 숫자가 5개뿐이라 단순 반복으로도 충분합니다.
                foreach (int num in combo) {
                    if (num == target) {
                        matchCount++;
                        break;
                    }
                }
            }

            // 시스템 응답(ans)과 일치하지 않으면 즉시 탈락
            if (matchCount != ans[i]) return false;
        }
        return true;
    }
}