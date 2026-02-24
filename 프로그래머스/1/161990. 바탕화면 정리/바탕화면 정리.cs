using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int lux = int.MaxValue;
        int luy = int.MaxValue;
        int rdx = int.MinValue;
        int rdy = int.MinValue;

        int rows = wallpaper.Length;
        int cols = wallpaper[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (wallpaper[i][j] == '#')
                {
                    // 가장 위쪽, 왼쪽
                    lux = Math.Min(lux, i);
                    luy = Math.Min(luy, j);

                    // 가장 아래쪽, 오른쪽
                    rdx = Math.Max(rdx, i + 1);
                    rdy = Math.Max(rdy, j + 1);
                }
            }
        }

        return new int[] { lux, luy, rdx, rdy };
    }
}
