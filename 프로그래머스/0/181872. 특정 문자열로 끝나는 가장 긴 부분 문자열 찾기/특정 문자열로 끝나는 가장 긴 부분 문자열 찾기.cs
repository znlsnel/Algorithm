using System;

public class Solution {
    public string solution(string myString, string pat) {
        // 1. pat이 마지막으로 등장하는 인덱스를 찾습니다.
        int lastIndex = myString.LastIndexOf(pat);
        
        // 2. 0번 인덱스부터 (마지막 인덱스 + pat의 길이)까지가 우리가 찾는 범위입니다.
        // Substring(시작위치, 길이)
        int length = lastIndex + pat.Length;
        
        return myString.Substring(0, length);
    }
}