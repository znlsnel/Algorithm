using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        // queries의 길이만큼 반복
        for (int q = 0; q < queries.GetLength(0); q++) {
            int s = queries[q, 0];
            int e = queries[q, 1];

            // s ≤ i ≤ e 범위의 arr[i]에 1 더하기
            for (int i = s; i <= e; i++) {
                arr[i]++;
            }
        }

        return arr;
    }
}
