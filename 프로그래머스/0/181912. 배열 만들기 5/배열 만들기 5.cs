using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> result = new List<int>();

        foreach (string str in intStrs)
        {
            // s번 인덱스부터 길이 l만큼 자르기
            string sub = str.Substring(s, l);

            // 정수로 변환
            int num = int.Parse(sub);

            // k보다 큰 경우만 추가
            if (num > k)
            {
                result.Add(num);
            }
        }

        return result.ToArray();
    }
}
