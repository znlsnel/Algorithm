using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    private List<(string, string)> Ticket = new List<(string, string)>();
    private Dictionary<string, List<int>> indices = new Dictionary<string, List<int>>();
    
    private List<string> answer = new List<string>();
    private bool[] visited;
    private int nodeCnt;
    private bool success = false;
    
    private void DFS(string node, int cnt)
    {
        answer.Add(node);
        
        if (answer.Count == Ticket.Count+1)
        {
            success = true;         
            return;
        }
        
        
        if (!indices.ContainsKey(node))
            return;
        
        foreach (int index in indices[node])
        {
            if (visited[index])
                continue;
            
            string nxt = Ticket[index].Item2;
            
            visited[index] = true;
            
            DFS(nxt, cnt + 1);
            if (answer.Count <= Ticket.Count())
            {
                visited[index] = false;
                answer.RemoveAt(answer.Count - 1);
            }
        
            
        }
        
        
        
    }
    
    public string[] solution(string[,] tickets) 
    {
        nodeCnt = tickets.GetLength(0);
        visited = new bool[nodeCnt];
        
        for (int i = 0; i < tickets.GetLength(0); i++)
            Ticket.Add((tickets[i, 0], tickets[i, 1]));
            
        
        Ticket.Sort();
        for (int i = 0; i < Ticket.Count; i++)
        {
            string from = Ticket[i].Item1;
            
            if (!indices.ContainsKey(from))
                indices.Add(from, new List<int>());
            
            indices[from].Add(i);
        }
        
        DFS("ICN", 0);
        
        return answer.ToArray();
    }
}