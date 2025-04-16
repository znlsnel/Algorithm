using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        
        char target = s[0];
        
        int xCnt = 1;
        int yCnt = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == target)
                xCnt++;
            else
                yCnt++;
            
            if (xCnt == yCnt)
            {
            //    Console.WriteLine($"{i} : {s[i]}");
                answer++;
                
                if (i < s.Length - 1)
                {
                    target = s[i+1];
                

                }
                xCnt = 0;
                yCnt = 0;
                
            }
        }
        
        if (xCnt != yCnt)
            answer++;
        
        return answer;
    }
}