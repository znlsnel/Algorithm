using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        List<int> hall = new List<int>();
        List<int> result = new List<int>();

        foreach (int s in score) {
            hall.Add(s);
            hall.Sort(); // 오름차순 정렬

            if (hall.Count > k) {
                hall.RemoveAt(0); // 가장 낮은 점수 제거
            }

            result.Add(hall[0]); // 현재 명예의 전당 최하위 점수
        }

        return result.ToArray();
    }
}
