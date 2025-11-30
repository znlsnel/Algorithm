using System;

public class Solution {
    public string[] solution(string my_string) {
        // 공백 기준으로 split, 빈 항목 제거
        string[] result = my_string.Split(
            new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries
        );
        return result;
    }
}