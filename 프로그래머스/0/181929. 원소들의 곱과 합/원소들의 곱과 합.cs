using System;

public class Solution {
    public int solution(int[] num_list) 
    {
        int sum = 0;
        for (int i = 0; i < num_list.Length; i++)
        {
            sum += num_list[i];
        }
        sum *= sum;
        int mul = num_list[0];
        for (int i = 1; i < num_list.Length; i++)
        {
            mul *= num_list[i];
            
            if (mul > sum)
            {
                return 0;
            }
        }
        
        return 1;
    }
}