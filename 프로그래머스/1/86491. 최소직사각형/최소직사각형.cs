using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxW = 0;
        int maxH = 0;

        for (int i = 0; i < sizes.GetLength(0); i++) {
            int w = sizes[i, 0];
            int h = sizes[i, 1];

            int big = Math.Max(w, h);
            int small = Math.Min(w, h);

            if (big > maxW) maxW = big;
            if (small > maxH) maxH = small;
        }

        return maxW * maxH;
    }
}
