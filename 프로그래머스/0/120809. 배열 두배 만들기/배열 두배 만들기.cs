using System;

public class Solution {
    public int[] solution(int[] numbers) {
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] *= 2;
        return numbers;
    }
}