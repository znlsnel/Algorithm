using System;
using System.Linq;

public class Solution {
    public int[] solution(string myString) {
        return myString
            .Split('x')                 // 'x' 기준으로 나누기
            .Select(s => s.Length)      // 각 문자열의 길이로 변환
            .ToArray();                 // 배열로 변환
    }
}
