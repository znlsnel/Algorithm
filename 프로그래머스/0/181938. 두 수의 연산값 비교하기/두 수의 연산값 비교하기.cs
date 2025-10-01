using System;

public class Solution {
    public int solution(int a, int b) {
        
    
        
        int X = 2 * a * b;
        int Y = b;
        int temp = a;
        while (b > 0)
        {
            temp *= 10;
            b /= 10;
        }
        
        Y += temp;
        
        
        return Math.Max(X, Y);
    }
}