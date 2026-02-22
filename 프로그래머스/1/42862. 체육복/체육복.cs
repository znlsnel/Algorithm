using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        // 1. 여벌이 있는데 도난당한 학생 제외 (LINQ 활용)
        // 실제 빌려줄 수 있는 학생들
        var actualReserve = reserve.Where(r => !lost.Contains(r)).OrderBy(r => r).ToList();
        // 실제로 체육복이 필요한 학생들
        var actualLost = lost.Where(l => !reserve.Contains(l)).OrderBy(l => l).ToList();

        // 2. 체육복 빌려주기
        for (int i = 0; i < actualLost.Count; i++) {
            int student = actualLost[i];
            
            // 앞번호 학생에게 빌릴 수 있는지 확인
            if (actualReserve.Contains(student - 1)) {
                actualReserve.Remove(student - 1);
                actualLost.RemoveAt(i);
                i--; // 리스트 요소 삭제에 따른 인덱스 조정
            }
            // 뒷번호 학생에게 빌릴 수 있는지 확인
            else if (actualReserve.Contains(student + 1)) {
                actualReserve.Remove(student + 1);
                actualLost.RemoveAt(i);
                i--;
            }
        }

        // 3. 전체 학생 수 - 끝까지 못 빌린 학생 수
        return n - actualLost.Count;
    }
}