using System;

public class Solution {
    public int solution(int[] d, int budget) {
        Array.Sort(d); // 작은 금액부터 정렬
        int count = 0;

        foreach (int cost in d) {
            if (budget - cost >= 0) {
                budget -= cost;
                count++;
            } else {
                break;
            }
        }

        return count;
    }
}
