using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands) 
    {
        List<int> answer = new List<int>();
        List<int> list = new List<int>(array);
        
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int s = commands[i, 0];
            int e = commands[i, 1];
            int k = commands[i, 2];
            
            List<int> temp = new List<int>();
            for (int j = s-1; j < e; j++)
                temp.Add(array[j]);
            
            temp.Sort();
            answer.Add(temp[k-1]);
        }
        
        return answer.ToArray();
    }
}