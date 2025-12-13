using System;

public class Solution {
    public int[] solution(int[] arr, int n) {

        bool isGhftn = arr.Length % 2 == 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (isGhftn ^ (i % 2 == 1))
                arr[i] += n;
        }
        return arr;
    }
}