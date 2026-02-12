using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        // 1. 수포자들의 반복 패턴 정의
        int[] p1 = { 1, 2, 3, 4, 5 };
        int[] p2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] p3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        
        // 2. 각자 맞힌 개수를 저장할 배열
        int[] scores = new int[3];

        // 3. 정답 배열과 비교 (나머지 연산 활용)
        for (int i = 0; i < answers.Length; i++) {
            if (answers[i] == p1[i % p1.Length]) scores[0]++;
            if (answers[i] == p2[i % p2.Length]) scores[1]++;
            if (answers[i] == p3[i % p3.Length]) scores[2]++;
        }

        // 4. 가장 높은 점수 찾기
        int maxScore = scores.Max();

        // 5. 최고 득점자 추출 (오름차순)
        List<int> winners = new List<int>();
        for (int i = 0; i < scores.Length; i++) {
            if (scores[i] == maxScore) {
                winners.Add(i + 1); // 인덱스는 0부터이므로 수포자 번호는 +1
            }
        }

        return winners.ToArray();
    }
}