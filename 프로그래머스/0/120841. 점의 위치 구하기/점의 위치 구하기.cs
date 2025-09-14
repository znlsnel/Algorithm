using System;

public class Solution {
    public int solution(int[] dot) {
        int answer = 0;
        if (dot[0] > 0)
        {
            return dot[1] > 0 ? 1 : 4;
            
        }
        else
        {
           return dot[1] > 0 ? 2 : 3; 
        }
        return answer;
    }
}