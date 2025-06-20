using System;

public class Solution {
    public int solution(int n, int k) {
        
        k -= Math.Max(0, (n / 10));
        return n*12000 + k*2000;
    }
}