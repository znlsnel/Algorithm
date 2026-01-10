using System;

public class Solution {
    int count = 0;

    public int solution(int[] numbers, int target) {
        DFS(numbers, target, 0, 0);
        return count;
    }

    private void DFS(int[] numbers, int target, int index, int sum) {
        // 모든 숫자를 사용한 경우
        if (index == numbers.Length) {
            if (sum == target)
                count++;
            return;
        }

        // 현재 숫자를 더하는 경우
        DFS(numbers, target, index + 1, sum + numbers[index]);

        // 현재 숫자를 빼는 경우
        DFS(numbers, target, index + 1, sum - numbers[index]);
    }
}
