using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        string temp = "";
        for (int i = 0; i < myString.Length; i++)
            temp += myString[i] == 'A' ? 'B' : 'A';
        
        return temp.Contains(pat) ? 1 : 0;
    }
}