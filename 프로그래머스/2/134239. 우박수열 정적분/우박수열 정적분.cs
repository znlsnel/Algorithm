using System;
using System.Collections.Generic;

public class Solution {
    public double[] solution(int k, int[,] ranges) {
        // 1. 우박수열 생성
        List<double> hail = new List<double>();
        hail.Add(k);

        while (k > 1)
        {
            if (k % 2 == 0) k /= 2;
            else k = k * 3 + 1;
            hail.Add(k);
        }

        int n = hail.Count;

        // 2. 구간별 사다리꼴 넓이 계산
        double[] area = new double[n - 1];
        for (int i = 0; i < n - 1; i++)
        {
            area[i] = (hail[i] + hail[i + 1]) / 2.0;
        }

        // 3. 누적합(prefix sum)
        double[] prefix = new double[n];
        for (int i = 0; i < n - 1; i++)
        {
            prefix[i + 1] = prefix[i] + area[i];
        }

        // 4. ranges 처리
        int len = ranges.GetLength(0);
        double[] answer = new double[len];

        for (int i = 0; i < len; i++)
        {
            int a = ranges[i, 0];
            int b = ranges[i, 1];

            int end = (n - 1) + b;  // b는 음수

            if (a > end)
            {
                answer[i] = -1.0;
                continue;
            }

            answer[i] = prefix[end] - prefix[a];
        }

        return answer;
    }
}
