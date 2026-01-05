using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int r1 = arr1.GetLength(0); // arr1 행 개수
        int c1 = arr1.GetLength(1); // arr1 열 개수
        int r2 = arr2.GetLength(0); // arr2 행 개수
        int c2 = arr2.GetLength(1); // arr2 열 개수

        int[,] answer = new int[r1, c2];

        for (int i = 0; i < r1; i++) {
            for (int j = 0; j < c2; j++) {
                int sum = 0;
                for (int k = 0; k < c1; k++) {
                    sum += arr1[i, k] * arr2[k, j];
                }
                answer[i, j] = sum;
            }
        }

        return answer;
    }
}
