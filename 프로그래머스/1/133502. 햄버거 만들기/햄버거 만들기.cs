using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        Stack<int> stack = new Stack<int>();

        foreach (int ing in ingredient)
        {
            stack.Push(ing);

            // 스택에 최소 4개 있어야 햄버거 검사 가능
            if (stack.Count >= 4)
            {
                int a = stack.Pop();
                int b = stack.Pop();
                int c = stack.Pop();
                int d = stack.Pop();

                // 1 2 3 1 패턴인지 확인
                if (d == 1 && c == 2 && b == 3 && a == 1)
                {
                    answer++; // 햄버거 완성
                }
                else
                {
                    // 패턴이 아니면 다시 원래대로 push
                    stack.Push(d);
                    stack.Push(c);
                    stack.Push(b);
                    stack.Push(a);
                }
            }
        }

        return answer;
    }
}
