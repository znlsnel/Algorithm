using System;
using System.Collections.Generic;

public class Solution 
{
    int answer = Int32.MaxValue;
    
    HashSet<(int, int, int)> visited = new HashSet<(int, int, int)>();
        
    int N, M;
    public void DFS(int[,] info, int A = 0, int B = 0, int idx = 0)
    {
        if (A >= answer || visited.Contains((A, B, idx)))
            return;
        
        visited.Add((A, B, idx));
        
        if (idx == info.GetLength(0))
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

        DFS(info);

        return answer == Int32.MaxValue ? -1 : answer;
    }
}