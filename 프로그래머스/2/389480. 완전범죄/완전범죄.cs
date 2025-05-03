using System;
using System.Collections.Generic;

public class Solution 
{
    const int MAX = 999999999;
    int answer = 999999999;
    
    HashSet<(int, int, int)> dp = new HashSet<(int, int, int)>();
        
    int N, M, TotalA = 0, TotalB=0;
    public void DFS(int[,] info, int A = 0, int B = 0, int idx = 0)
    {
        if (A >= answer)
            return;
        
        if (dp.Contains((A, B, idx)))
            return;
        
        dp.Add((A, B, idx));
        
        if (idx == info.GetLength(0) || TotalB <= B)
        {
            answer = Math.Min(answer, A);
            return;
        }
        
        bool CanA = A + info[idx, 0] < N;
        bool CanB = B + info[idx, 1] < M;
        
        if (CanB)
            DFS(info, A, B + info[idx, 1], idx + 1);
        if (CanA)
            DFS(info, A + info[idx, 0], B, idx + 1);
        
    }
    
    public int solution(int[,] info, int n, int m) 
    {
        int size = info.GetLength(0);
        N = n;
        M = m;
        
        for (int i = 0; i < size; i++)
        {
            TotalA += info[i, 0];
            TotalB += info[i, 1];
        }
        
        if (TotalB < M)
            return 0;
        
        DFS(info);
        
        
        return answer == MAX ? -1 : answer;
    }
}