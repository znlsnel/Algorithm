using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        foreach (int num in numbers)
        {
            answer += num;
            if (answer > n)
                break;
        }
        return answer;
    }
}