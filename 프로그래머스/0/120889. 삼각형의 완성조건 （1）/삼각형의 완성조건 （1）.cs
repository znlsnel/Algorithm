using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int maxIdx = 0;
        int total = 0;
        
        for (int i = 1; i < sides.Length; i++)
        {
            if (sides[i] > sides[maxIdx])
                maxIdx = i;
        }
        
        for (int i = 0; i < sides.Length; i++)
        {
            if (i != maxIdx)
                total += sides[i];
        }
        
        
            
            
        return total > sides[maxIdx] ? 1 : 2;
    }
}