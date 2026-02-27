using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        // 1. 문자열을 문자 배열로 변환
        char[] chars = my_string.ToCharArray();

        // 2. s 인덱스부터 (e - s + 1)개의 요소를 뒤집기
        // Array.Reverse(배열, 시작인덱스, 뒤집을길이)
        Array.Reverse(chars, s, e - s + 1);

        // 3. 배열을 다시 문자열로 생성하여 반환
        return new string(chars);
    }
}