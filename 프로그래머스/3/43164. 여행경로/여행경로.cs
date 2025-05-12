using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    private List<(string, string)> Ticket = new List<(string, string)>();
    private Dictionary<string, List<int>> indices = new Dictionary<string, List<int>>();
    
    private List<string> answer = new List<string>();
    private bool[] visited;
    
    private void DFS(string node, int cnt)
    {
        answer.Add(node);
        
        if (answer.Count == Ticket.Count+1 || !indices.ContainsKey(node))
            return;
        
        foreach (int index in indices[node])
        {
            if (visited[index])
                continue;

            visited[index] = true;
            
            string nxt = Ticket[index].Item2;
            DFS(nxt, cnt + 1);

            if (answer.Count <= Ticket.Count)
            {
                visited[index] = false;
                answer.RemoveAt(answer.Count - 1);
            }
        } 
    }
    
    public string[] solution(string[,] tickets) 
    {
        visited = new bool[tickets.GetLength(0)];
        
        for (int i = 0; i < tickets.GetLength(0); i++)
            Ticket.Add((tickets[i, 0], tickets[i, 1]));
            
        Ticket.Sort();
        for (int i = 0; i < Ticket.Count; i++)
        {
            if (!indices.ContainsKey(Ticket[i].Item1))
                indices.Add(Ticket[i].Item1, new List<int>());
            
            indices[Ticket[i].Item1].Add(i);
        }
        
        DFS("ICN", 0);
        
        return answer.ToArray();
    }
}