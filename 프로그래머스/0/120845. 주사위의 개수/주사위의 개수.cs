using System;

public class Solution {
    public int solution(int[] box, int n) {
        int x = box[0] / n;
        int y = box[1] / n;
        int z = box[2] / n;
        return x * y * z;
    }
}