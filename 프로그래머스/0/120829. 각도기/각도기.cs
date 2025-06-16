using System;

public class Solution {
    public int solution(int a) {
        return a == 180 ? 4 : a == 90 ? 2 : a < 90 ? 1 : 3;
    }
}