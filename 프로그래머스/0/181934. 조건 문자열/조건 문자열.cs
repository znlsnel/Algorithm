using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
        
        
        
        if (ineq == ">")
        {
            
            if (eq == "=")
                return n >= m ? 1 : 0;
            else
                return n > m ? 1 : 0;
        }
        else
        {
            if (eq == "=")
                return n <= m ? 1 : 0;
            else
                return n < m ? 1 : 0;
        }    
        
        
        return answer;
    }
}