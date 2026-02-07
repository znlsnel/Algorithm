using System;
using System.Text;

public class Solution {
    public string solution(int[] food) {
        StringBuilder left = new StringBuilder();

        for (int i = 1; i < food.Length; i++) {
            int count = food[i] / 2;
            for (int j = 0; j < count; j++) {
                left.Append(i);
            }
        }

        // 직접 뒤집기
        char[] arr = left.ToString().ToCharArray();
        Array.Reverse(arr);
        string right = new string(arr);

        return left.ToString() + "0" + right;
    }
}
