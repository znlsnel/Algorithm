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
			HashSet<int>[] outDegree = new HashSet<int>[n+1];
			int[] inDegree = new int[n+1];

			for (int i = 0; i < n+1; i++)
				outDegree[i] = new HashSet<int>();

			for (int i = 0; i < n; i++)
			{
				for (int j = i+1; j < n; j++)
				{
					int higher = rank[i];
					int lower = rank[j];

					if (outDegree[higher].Add(lower))
						inDegree[lower]++;
				}
			}

			foreach ((int a, int b) in newRanks)
			{
				// 원래 a가 b보다 높았을 때
				if (outDegree[a].Contains(b)) 
				{
					outDegree[a].Remove(b);
					outDegree[b].Add(a);
					inDegree[a]++;
					inDegree[b]--;
				}
				else
				{
					outDegree[b].Remove(a);
					outDegree[a].Add(b);
					inDegree[b]++;
					inDegree[a]--;
				}
			}

			List<int> answer = new List<int>();
			Queue<int> q = new Queue<int>();
			for (int i = 1; i < n+1; i++)
				if (inDegree[i] == 0)
					q.Enqueue(i); 

			for (int i = 0; i < rank.Count; i++)
			{
				if (q.Count == 0)
				{
					 Console.WriteLine("IMPOSSIBLE");
					return;
				}
				if (q.Count > 1)
				{
					Console.WriteLine("?");
					return;
				}

				int cur = q.Dequeue();
				answer.Add(cur);

				foreach (int next in outDegree[cur])
				{
					inDegree[next]--;

					if (inDegree[next] == 0)
						q.Enqueue(next);
				}
			}

			Console.WriteLine(string.Join(" ", answer));
		}

		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			for (int i = 0; i < count; i++)
				Solution();
		}
	}
}