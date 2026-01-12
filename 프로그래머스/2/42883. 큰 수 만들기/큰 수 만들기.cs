using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string number, int k) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in number) {
            while (k > 0 && stack.Count > 0 && stack.Peek() < c) {
                stack.Pop();
                k--;
            }
            stack.Push(c);
        }

        // 아직 제거해야 할 k가 남아 있으면 뒤에서 제거
        while (k > 0) {
            stack.Pop();
            k--;
        }

        // 스택은 뒤집혀 있으므로 다시 뒤집기
        char[] arr = stack.ToArray();
        Array.Reverse(arr);

        return new string(arr);
    }
}
