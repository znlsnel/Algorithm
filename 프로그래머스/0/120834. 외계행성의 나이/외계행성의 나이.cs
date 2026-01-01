using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        string s = age.ToString();

        foreach(char c in s) {
            int num = c - '0';          // 숫자 문자 → 정수
            char alpha = (char)('a' + num); // 0→a, 1→b …
            answer += alpha;
        }

        return answer;
    }
}
