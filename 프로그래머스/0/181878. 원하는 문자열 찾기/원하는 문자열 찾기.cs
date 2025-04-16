using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        myString = myString.ToLower();
        pat= pat.ToLower();
        
        answer = myString.IndexOf(pat);
        
        return answer == -1 ? 0 : 1;
    }
}