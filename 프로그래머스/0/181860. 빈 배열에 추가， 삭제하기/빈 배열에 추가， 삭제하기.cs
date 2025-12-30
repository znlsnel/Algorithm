using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        List<int> X = new List<int>();

        for (int i = 0; i < arr.Length; i++) {
            if (flag[i]) {
                // arr[i]를 arr[i] * 2번 추가
                for (int k = 0; k < arr[i] * 2; k++) {
                    X.Add(arr[i]);
                }
            } else {
                // 마지막 arr[i]개의 원소 제거
                X.RemoveRange(X.Count - arr[i], arr[i]);
            }
        }

        return X.ToArray();
    }
}
