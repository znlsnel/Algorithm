using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int l, int r) 
    {
        List<int> answer = new List<int>();
        
        for (int i = l; i <= r; i++)
        {
            string num = i.ToString();
            
            bool flag = true;
            foreach (char c in num)
            {
                if (c != '5' && c != '0')
                {
                    flag = false;
                    break;
                }
            }
            
            if (flag)
                answer.Add(i);
            
        }
        
        if (answer.Count == 0)
            answer.Add(-1);
        
        return answer.ToArray();
    }
}