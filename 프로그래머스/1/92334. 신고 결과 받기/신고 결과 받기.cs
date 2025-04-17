using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] id_list, string[] report, int k) 
    {
        Dictionary<string, int> names = new Dictionary<string, int>();
        Dictionary<string, HashSet<string>> logs = new Dictionary<string, HashSet<string>>();

        int[] answer = new int[id_list.Length];
        
        for (int i = 0; i < id_list.Length; i++)
            names.Add(id_list[i], i);
        
        
        for (int i = 0; i < report.Length; i++)
        {
            string[] users = report[i].Split(' ');
            string userA = users[0];
            string userB = users[1];
            
            if (logs.TryGetValue(userB, out HashSet<string> h))
            {
                // 신고한 사람 등록
                h.Add(userA);
                continue;
            }
            h = new HashSet<string>();
            h.Add(userA);
            logs.Add(userB, h);
        }
        
        
        foreach (var log in logs)
        {
            if (log.Value.Count >= k)
            {
                foreach (var user in log.Value)
                {
                    answer[names[user]]++;   
                }
            }
        }
    
        
            
        
        
        // 신고한적이 있는지?
        // 신고당한 횟수를 저장
        
        
        
        return answer;
    }
}