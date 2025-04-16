using System;

// 레벨 1 문제 -> 가벼운 넌센스
// 레벨 2 문제 -> 무거운 넌세스, 넌센스 섞인
// 레벨 3 문제 -> 너 알고리즘 알아?
// 레벨 4 문제 -> 너 알고리즘 알아 * 자료구조 활용 잘해? * 넌센스 좀 알아?


public class Solution 
{
    
    public int solution(string t, string p) 
    {
        int answer = 0;
        long pSize = long.Parse(p);
        
        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            string str = t.Substring(i, p.Length);
            
            long aSize = long.Parse(str);
            
            if (aSize <= pSize)
                answer++;       
        }

        return answer;
    }
    
}