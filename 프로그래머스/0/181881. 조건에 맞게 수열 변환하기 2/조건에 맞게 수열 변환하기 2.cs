using System;

public class Solution 
{
    public int solution(int[] arr) 
    {
        int answer = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            int cnt = 0;
            while (true)
            {
                bool flag = true;
                if (arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    arr[i] = arr[i] / 2;
                    flag = false;
                }
            
                else if (arr[i] < 50 && arr[i] % 2 == 1)
                {
                    arr[i] = arr[i] * 2 + 1;
                    flag = false;
                }
                
                if (flag)
                    break;
                else
                {
                    answer = Math.Max(answer, ++cnt);
                }
            }
            
            
            
        }
        
        return answer;
    }
}