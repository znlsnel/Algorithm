using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2]{-1, 100000};
        
        for (int i = 0; i < array.Length; i++)
        {
            int n = array[i];
            if (n > answer[0])
            {
                answer[0] = n;
                answer[1] = i;
            }
        }
        
        
        return answer;
    }
}