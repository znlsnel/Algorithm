using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string word) 
    {
        Dictionary<char, int> order = new Dictionary<char, int>()
        {
            {'A', 0},
            {'E', 1},
            {'I', 2},
            {'O', 3},
            {'U', 4}
        };
        
        int[] dp = new int[5];
        dp[4] = 1;
        for (int i = 3; i >= 0; i--)
            dp[i] = dp[i + 1] * 5 + 1;
        
        int answer = 0;
        
        for (int i = 0; i < word.Length; i++)
            answer += 1 + dp[i] * order[word[i]];
        
        return answer;
    }
}


// A AA AAA AAAA

// AAAAA AAAAE AAAAI AAAAO AAAAU
// AAAE  AAAEA AAAEE AAAEI AAAEO AAAEU
// AAAI  AAAIA AAAIE AAAII AAAIO AAAIU
// AAAO  AAAOA AAAOE AAAOI AAAOO AAAOU
// AAAU  AAAUA AAAUE AAAUI AAAUO AAAUU
// AAE 

//AAAI AAAO AAAU
// AAE AAI AAO AAU
// AE AI AO AU
// E


