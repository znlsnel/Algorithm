using System;
using System.Text;

public class Solution {
    public string solution(string[] arr) {
        StringBuilder sb = new StringBuilder();
        foreach (string s in arr)
        {
            sb.Append(s);
        }
        return sb.ToString();
    }
}