using System;
using System.Linq;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        
        int idx = binomial.IndexOf("+");
        if (idx == -1)
            idx = binomial.IndexOf("-");
        if (idx == -1)
            idx = binomial.IndexOf("*");
        
        int numA = int.Parse(binomial.Substring(0, idx-1));
        int numB = int.Parse(binomial.Substring(idx+2, binomial.Length - (idx+2)));
        
        char c = binomial[idx];
        
        if (c == '+')
            return numA + numB;
        
        if (c == '-')
            return numA - numB;
        
        return numA * numB;
        
    }
}