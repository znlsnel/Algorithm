using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        StringBuilder sb = new StringBuilder();
        foreach (int idx in index_list)
            sb.Append(my_string[idx]);
        return sb.ToString();
    }
}