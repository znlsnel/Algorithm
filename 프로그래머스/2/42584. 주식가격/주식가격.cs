using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices) {
        int n = prices.Length;
        int[] answer = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++) {
            // 가격이 떨어지는 순간 스택에서 처리
            while (stack.Count > 0 && prices[stack.Peek()] > prices[i]) {
                int idx = stack.Pop();
                answer[idx] = i - idx;
            }
            stack.Push(i);
        }

        // 끝까지 가격이 떨어지지 않은 경우 처리
        while (stack.Count > 0) {
            int idx = stack.Pop();
            answer[idx] = n - 1 - idx;
        }

        return answer;
    }
}
