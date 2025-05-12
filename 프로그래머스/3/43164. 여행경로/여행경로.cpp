#include <bits/stdc++.h>
#include <iostream>
using namespace std;

vector<string> answer;
bool visited[10001];

void dfs(vector<vector<string>>& tickets, string start)
{
    answer.push_back(start);
    
    if (answer.size() == tickets.size() + 1)
        return;
    
    
    for (int i = 0; i < tickets.size(); i++)
    {
        if (visited[i])
            continue;
        
        string s = tickets[i][0];
        string e = tickets[i][1];
        
        if (s == start)
        {
            visited[i] = true;
            dfs(tickets, e);
            if (answer.size() <= tickets.size())
            {
                visited[i] = false;
                answer.pop_back();
            }
        }
    }
    
}

vector<string> solution(vector<vector<string>> tickets) {
    sort(tickets.begin(), tickets.end());

    dfs(tickets, "ICN");
    
    return answer;
}