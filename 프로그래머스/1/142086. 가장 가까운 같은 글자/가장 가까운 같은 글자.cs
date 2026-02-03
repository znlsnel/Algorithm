using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        Dictionary<char, int> lastIndex = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];

            if (lastIndex.ContainsKey(c)) {
                answer[i] = i - lastIndex[c];
                lastIndex[c] = i;
            } else {
                answer[i] = -1;
                lastIndex[c] = i;
            }
        }

        return answer;
    }
}
