using System;

public class Solution 
{
    public int solution(int[] A, int[] B) 
    {
        int answer = 0;
        Array.Sort(A, (a, b) => b.CompareTo(a));
        Array.Sort(B, (a, b) => b.CompareTo(a));

        
        int idxB = 0;
        int idxA = 0;
        
        while (idxA < A.Length && idxB < B.Length)
        {
            if (A[idxA] < B[idxB])
            {
                idxA++;
                idxB++;
                answer++;
            }
            else if (A[idxA] >= B[idxB])
                idxA++;
        }
        
        return answer;
    }
}

// 5 1 3 7
// 2 2 6 8

// 7 3 1 1
// 9 9 9 2