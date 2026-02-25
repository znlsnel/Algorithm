using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        // 1. 각 성격 유형의 점수를 저장할 딕셔너리 초기화
        Dictionary<char, int> scores = new Dictionary<char, int>() {
            {'R', 0}, {'T', 0}, {'C', 0}, {'F', 0},
            {'J', 0}, {'M', 0}, {'A', 0}, {'N', 0}
        };

        // 2. 설문 결과에 따른 점수 합산
        for (int i = 0; i < survey.Length; i++) {
            int choice = choices[i];
            
            if (choice < 4) { // 비동의 관련 (첫 번째 캐릭터)
                scores[survey[i][0]] += (4 - choice);
            } else if (choice > 4) { // 동의 관련 (두 번째 캐릭터)
                scores[survey[i][1]] += (choice - 4);
            }
        }

        // 3. 지표별로 최종 성격 유형 결정
        StringBuilder answer = new StringBuilder();
        
        // 1번 지표: R, T
        answer.Append(scores['R'] >= scores['T'] ? 'R' : 'T');
        // 2번 지표: C, F
        answer.Append(scores['C'] >= scores['F'] ? 'C' : 'F');
        // 3번 지표: J, M
        answer.Append(scores['J'] >= scores['M'] ? 'J' : 'M');
        // 4번 지표: A, N
        answer.Append(scores['A'] >= scores['N'] ? 'A' : 'N');

        return answer.ToString();
    }
}