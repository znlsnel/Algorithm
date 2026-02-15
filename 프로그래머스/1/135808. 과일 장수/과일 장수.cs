using System;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;

        // 점수를 내림차순 정렬
        Array.Sort(score);
        Array.Reverse(score);

        // m개씩 묶어서 계산
        for (int i = m - 1; i < score.Length; i += m) {
            int minScore = score[i];   // 묶음의 최소값
            answer += minScore * m;
        }

        return answer;
    }
}
