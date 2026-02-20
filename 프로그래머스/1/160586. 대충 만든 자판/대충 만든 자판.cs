using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] minPress = new int[26];

        // 초기값: 매우 큰 값
        for (int i = 0; i < 26; i++)
            minPress[i] = int.MaxValue;

        // keymap에서 각 문자 최소 입력 횟수 계산
        foreach (string key in keymap)
        {
            for (int i = 0; i < key.Length; i++)
            {
                int idx = key[i] - 'A';
                minPress[idx] = Math.Min(minPress[idx], i + 1);
            }
        }

        int[] answer = new int[targets.Length];

        // target 문자열 처리
        for (int t = 0; t < targets.Length; t++)
        {
            int sum = 0;
            bool possible = true;

            foreach (char c in targets[t])
            {
                int idx = c - 'A';

                if (minPress[idx] == int.MaxValue)
                {
                    possible = false;
                    break;
                }

                sum += minPress[idx];
            }

            answer[t] = possible ? sum : -1;
        }

        return answer;
    }
}
