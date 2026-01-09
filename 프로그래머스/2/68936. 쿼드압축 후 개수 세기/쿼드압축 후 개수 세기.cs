using System;

public class Solution {
    int[] answer = new int[2]; // answer[0] = 0의 개수, answer[1] = 1의 개수

    public int[] solution(int[,] arr) {
        int n = arr.GetLength(0);
        Compress(arr, 0, 0, n);
        return answer;
    }

    // 특정 영역이 모두 같은 값인지 확인
    private bool IsSame(int[,] arr, int x, int y, int size) {
        int first = arr[x, y];
        for (int i = x; i < x + size; i++) {
            for (int j = y; j < y + size; j++) {
                if (arr[i, j] != first)
                    return false;
            }
        }
        return true;
    }

    // 쿼드 압축 함수
    private void Compress(int[,] arr, int x, int y, int size) {
        if (IsSame(arr, x, y, size)) {
            answer[arr[x, y]]++; // 0 또는 1 증가
            return;
        }

        int half = size / 2;

        // 4개 영역으로 분할
        Compress(arr, x, y, half);
        Compress(arr, x, y + half, half);
        Compress(arr, x + half, y, half);
        Compress(arr, x + half, y + half, half);
    }
}
