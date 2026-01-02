using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int rows = num_list.Length / n;     // 몇 줄인지 계산
        int[,] answer = new int[rows, n];   // 2차원 배열 생성

        for (int i = 0; i < num_list.Length; i++) {
            answer[i / n, i % n] = num_list[i];
        }

        return answer;
    }
}
