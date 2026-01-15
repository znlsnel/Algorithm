using System;

public class Solution {
    public long solution(long n) {
        long x = (long)Math.Sqrt(n);

        if (x * x == n)
            return (x + 1) * (x + 1);

        return -1;
    }
}
