using System;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[strArr.Length];
        
        for (int i = 0; i < strArr.Length; i++) {
            if (i % 2 == 0) {
                // 짝수 인덱스 → 소문자
                answer[i] = strArr[i].ToLower();
            } else {
                // 홀수 인덱스 → 대문자
                answer[i] = strArr[i].ToUpper();
            }
        }
        
        return answer;
    }
}
