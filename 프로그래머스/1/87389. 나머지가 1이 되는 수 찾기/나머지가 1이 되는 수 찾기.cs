using System;

public class Solution {
    public int solution(int n) {

        
        for (int i = 2; i < n; i++)
        {
            if (n % i == 1)
                return i;
        }
        
        return 1;
    }
}