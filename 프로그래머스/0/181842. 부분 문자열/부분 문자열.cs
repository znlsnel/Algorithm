using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        
        for (int i = 0; i <= str2.Length - str1.Length; i++)
        {
            if (str2.Substring(i, str1.Length) == str1)
                return 1;
        }
        return 0;
    }
}