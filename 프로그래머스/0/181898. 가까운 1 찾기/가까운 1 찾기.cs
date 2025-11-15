using System;

public class Solution {
    public int solution(int[] arr, int idx) {
        int answer = -1;
        for (int i = idx; i < arr.Length; i++)
        {
            if (arr[i] == 1)
                return i;
        }
        return answer;
    }
}