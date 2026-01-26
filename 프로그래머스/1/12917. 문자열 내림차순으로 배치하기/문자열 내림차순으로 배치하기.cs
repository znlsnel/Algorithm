using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        return new string(s.OrderByDescending(c => c).ToArray());
    }
}
