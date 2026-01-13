using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        // 인접 리스트 생성
        List<(int to, int cost)>[] graph = new List<(int, int)>[N + 1];
        for (int i = 1; i <= N; i++)
            graph[i] = new List<(int, int)>();

        // 도로 정보 입력
        int len = road.GetLength(0);
        for (int i = 0; i < len; i++)
        {
            int a = road[i, 0];
            int b = road[i, 1];
            int c = road[i, 2];

            graph[a].Add((b, c));
            graph[b].Add((a, c));
        }

        // 거리 배열 (최소 거리 저장)
        int[] dist = new int[N + 1];
        for (int i = 1; i <= N; i++)
            dist[i] = int.MaxValue;

        dist[1] = 0;

        // 다익스트라: 우선순위 큐 대신 List 사용
        List<(int node, int cost)> pq = new List<(int, int)>();
        pq.Add((1, 0));

        while (pq.Count > 0)
        {
            // 가장 비용이 적은 노드 선택
            pq.Sort((a, b) => a.cost.CompareTo(b.cost));
            var current = pq[0];
            pq.RemoveAt(0);

            int now = current.node;
            int nowCost = current.cost;

            if (nowCost > dist[now]) continue;

            foreach (var next in graph[now])
            {
                int nextNode = next.to;
                int nextCost = nowCost + next.cost;

                if (nextCost < dist[nextNode])
                {
                    dist[nextNode] = nextCost;
                    pq.Add((nextNode, nextCost));
                }
            }
        }

        // K 이하인 마을 개수 세기
        int answer = 0;
        for (int i = 1; i <= N; i++)
        {
            if (dist[i] <= K)
                answer++;
        }

        return answer;
    }
}
