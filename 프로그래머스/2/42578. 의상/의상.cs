using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        Dictionary<string, int> map = new Dictionary<string, int>();

        // 종류별 개수 세기
        for (int i = 0; i < clothes.GetLength(0); i++) {
            string type = clothes[i, 1];
            if (!map.ContainsKey(type))
                map[type] = 0;
            map[type]++;
        }

        // 조합 계산
        int answer = 1;
        foreach (var item in map) {
            answer *= (item.Value + 1); // 입지 않는 경우 포함
        }

        return answer - 1; // 모두 안 입는 경우 제외
    }
}
