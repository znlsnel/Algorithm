using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        for (int i = 1; i < numLog.Length; i++)
        {
            int prev = numLog[i-1];
            int cur = numLog[i];
            
            int diff = cur - prev; 
            if (diff == 1)
            {
                answer += "w";
            }
            else if (diff == -1)
                answer += "s";
            else if (diff == 10)
                answer += "d";
            else if (diff == -10)
                answer += "a";
        }
        return answer;
    }
}