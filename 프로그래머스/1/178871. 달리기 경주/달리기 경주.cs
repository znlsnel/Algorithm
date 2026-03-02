using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        int n = players.Length;

        // 선수 이름 → 현재 등수(index)
        Dictionary<string, int> rank = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
            rank[players[i]] = i;

        foreach (string name in callings) {
            int cur = rank[name];      // 현재 등수
            int prev = cur - 1;        // 앞 선수 등수

            // 앞 선수 이름
            string frontPlayer = players[prev];

            // swap
            players[prev] = name;
            players[cur] = frontPlayer;

            // dictionary 업데이트
            rank[name] = prev;
            rank[frontPlayer] = cur;
        }

        return players;
    }
}
