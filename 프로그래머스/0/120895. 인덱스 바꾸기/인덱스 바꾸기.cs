using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        StringBuilder sb = new StringBuilder();
        
        sb.Append(my_string);
        
        sb[num1] = my_string[num2];
        sb[num2] = my_string[num1];
        
        return sb.ToString();
    }
}