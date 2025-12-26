using System;

public class Solution {
    public int solution(int[] date1, int[] date2) {
        // year 비교
        if (date1[0] < date2[0]) return 1;
        if (date1[0] > date2[0]) return 0;

        // month 비교
        if (date1[1] < date2[1]) return 1;
        if (date1[1] > date2[1]) return 0;

        // day 비교
        if (date1[2] < date2[2]) return 1;
        
        return 0;
    }
}
