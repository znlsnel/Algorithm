using System;
using System.Text;

public class Solution {
    public string solution(string rsp) {
        StringBuilder sb = new StringBuilder();
        foreach (char r in rsp)
        {
            sb.Append(r == '2' ? "0" : r == '0' ? "5" : "2");
        }
        return sb.ToString();
    }
}