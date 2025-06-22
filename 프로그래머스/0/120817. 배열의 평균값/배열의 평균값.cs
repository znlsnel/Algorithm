using System;

public class Solution {
    public double solution(int[] numbers) {
        float total = 0f;
        
        foreach (int num in numbers)
            total += num;

        return total / numbers.Length;
    }
}