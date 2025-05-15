using System;
using System.Linq;
using System.Collections.Generic;


public class Solution 
{
    public int solution(int[,] t) 
    {
        int answer = 1;
        
        List<(int, int)> targets = new List<(int, int)>();
        for (int i = 0; i < t.GetLength(0); i++)
            targets.Add((t[i, 0], t[i, 1]));
        
        targets.Sort((A, B) => {
            if (A.Item2 == B.Item2)
                return A.Item1 < B.Item1 ? -1 : 1;
            return A.Item2 < B.Item2 ? -1 : 1;
        });
        
        int e = targets[0].Item2;
        
        for (int i = 1; i < targets.Count; i++)
        {
            int start = targets[i].Item1;
            int end = targets[i].Item2;
           // Console.WriteLine($"{start} -> {end}");
            
            if (start < e)
                continue;
            
            answer++;
            e = end;
            
        }
        
        return answer;
    }
}

