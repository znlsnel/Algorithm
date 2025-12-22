using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {
        return myString
            .Split('x')                 // "x" 기준으로 문자열 분할
            .Where(s => s != "")        // 빈 문자열 제거
            .OrderBy(s => s)            // 사전순 정렬
            .ToArray();                 // 배열로 변환
    }
}
