using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int k) {
        StringBuilder sb = new StringBuilder();
        while (k-- > 0)
        {
            sb.Append(my_string);
        }
        return sb.ToString();
    }
}