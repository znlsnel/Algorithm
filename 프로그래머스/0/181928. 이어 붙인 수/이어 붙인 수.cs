using System;

public class Solution {
    public int solution(int[] num_list) {
        int numA = 0, numB = 0;
        
        foreach (int num in num_list)
        {
            if (num % 2 == 0)
            {
                numA *= 10;
                numA += num;
            }
            else
            {
                numB *= 10;
                numB += num;
            }
        }
    
        return numA + numB;
    }
}