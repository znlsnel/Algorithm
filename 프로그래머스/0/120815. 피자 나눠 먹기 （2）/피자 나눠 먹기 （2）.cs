using System;

public class Solution {
    public int solution(int n) {
        int gcd = GCD(6, n);
        int lcm = 6 * n / gcd;
        return lcm / 6;
    }
    
    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
}
