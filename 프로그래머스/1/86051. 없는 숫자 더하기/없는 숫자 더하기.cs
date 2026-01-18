using System;

public class Solution {
    public int solution(int[] numbers) {
        int total = 45; // 0~9까지의 합
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return total - sum;
    }
}
