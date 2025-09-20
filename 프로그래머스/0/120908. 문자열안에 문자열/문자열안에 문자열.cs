using System;

public class Solution {
    public int solution(string str1, string str2) {
        for (int i = 0; i <= str1.Length - str2.Length; i++)
        {
            if (str1.Substring(i, str2.Length) == str2)
                return 1;
            
        }
        return 2;
    }
}