using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        int answer = 0;
        foreach (int num in num_list)
        {
            if (n == num)
                return 1;
        }
        return 0;
    }
}