using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        if (num_list.Length >= 11)
        {
            foreach (int n in num_list)
                answer += n;
        }
        else
        {
            answer = 1;
            foreach (int n in num_list)
            {
                answer *= n;
            }
            
        }
        return answer;
    }
}