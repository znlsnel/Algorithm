using System;
using System.Collections.Generic;
using System.Linq;

namespace Alroghtim_CS
{
	class Program
	{
		static void Input(out List<int> rank, out List<(int, int)> newRanks)
		{
			rank = new List<int>();
			newRanks = new List<(int, int)>();

			int n = int.Parse(Console.ReadLine());
			string[] ranking = Console.ReadLine().Split(' ');
			for (int i = 0; i < n; i++)
				rank.Add(int.Parse(ranking[i]));

			int m = int.Parse(Console.ReadLine());

			for (int i = 0; i < m; i++)
			{
				string[] newRank = Console.ReadLine().Split(' ');
				int a = int.Parse(newRank[0]);
				int b = int.Parse(newRank[1]);
				newRanks.Add((a, b));
			}
		}

		static void Solution()
		{
			Input(out List<int> rank, out List<(int, int)> newRanks);

			int n = rank.Count;
			HashSet<int>[] outDegreeSets = new HashSet<int>[n + 1]; // 각 노드에서 나가는 간선을 저장
			int[] inDegreeCounts = new int[n + 1]; // 각 노드의 진입 차수를 저장

			for (int i = 1; i <= n; i++) // 1번부터 n번 팀까지 초기화
			{
				outDegreeSets[i] = new HashSet<int>();
			}

			// 1. 작년 순위를 기반으로 그래프 구성
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					int higherRankTeam = rank[i]; // 더 높은 순위의 팀
					int lowerRankTeam = rank[j];  // 더 낮은 순위의 팀
					// 간선: higherRankTeam -> lowerRankTeam
					if (outDegreeSets[higherRankTeam].Add(lowerRankTeam))
					{
						inDegreeCounts[lowerRankTeam]++;
					}
				}
			}

			// 2. 순위 변경 처리
			foreach (var (a, b) in newRanks)
			{
				// 원래 관계를 확인하고 반대로 변경
				if (outDegreeSets[a].Contains(b)) // 원래: a -> b (a가 더 높았음)
				{
					// a -> b 간선 제거
					outDegreeSets[a].Remove(b);
					inDegreeCounts[b]--;
					// b -> a 간선 추가
					outDegreeSets[b].Add(a);
					inDegreeCounts[a]++;
				}
				else // 원래: b -> a (b가 더 높았음)
				{
					// b -> a 간선 제거
					outDegreeSets[b].Remove(a);
					inDegreeCounts[a]--;
					// a -> b 간선 추가
					outDegreeSets[a].Add(b);
					inDegreeCounts[b]++;
				}
			}

			// 3. 위상 정렬
			Queue<int> queue = new Queue<int>();
			for (int i = 1; i <= n; i++)
			{
				if (inDegreeCounts[i] == 0)
					queue.Enqueue(i);
			}

			List<int> answer = new List<int>();
			bool isAmbiguous = false; // 모호성 플래그

			while (queue.Count > 0) // 큐가 빌 때까지 반복
			{
				// 큐에서 꺼내기 전에 모호성 확인
				if (queue.Count > 1)
				{
					isAmbiguous = true;
				}

				int cur = queue.Dequeue();
				answer.Add(cur);

				// 현재 노드에서 나가는 간선 처리
				// ToList()를 사용하여 반복 중 컬렉션 수정 문제 방지
				foreach (int next in outDegreeSets[cur].ToList())
				{
					// cur -> next 간선 제거 (진입 차수 감소)
					inDegreeCounts[next]--;
					if (inDegreeCounts[next] == 0)
						queue.Enqueue(next);
				}
			}

			// 결과 확인
			if (answer.Count != n) // 모든 노드를 처리하지 못한 경우
			{
				Console.WriteLine("IMPOSSIBLE"); // 사이클 존재
			}
			else if (isAmbiguous)
			{
				Console.WriteLine("?"); // 모호한 순위
			}
			else
			{
				Console.WriteLine(string.Join(" ", answer)); // 유일한 위상 정렬 결과
			}
		}

		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			for (int i = 0; i < count; i++)
				Solution();
		}
	}
}