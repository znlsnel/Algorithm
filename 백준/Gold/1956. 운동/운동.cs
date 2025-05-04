using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Solution
{
	const int MaxValue = Int32.MaxValue / 10;

	public int solution(int V, int E, int[, ] edges)
	{
		int[, ] graph = new int[V, V];
		for (int i = 0; i < V; i++)
		{
			for (int j = 0; j < V; j++)
				graph[i, j] = i == j ? 0 : MaxValue;
		}

		for (int i = 0; i < E; i++)
		{
			int s = edges[i, 0]-1;
			int e = edges[i, 1]-1;
			int c = edges[i, 2];
			graph[s, e] = c; 
		}

		for (int k = 0; k < V; k++)
		{
			for (int i = 0; i < V; i++)
			{
				for (int j = 0; j < V; j++)
				{
					if (graph[i, k] == MaxValue || graph[k, j] == MaxValue)
						continue;

					int cost = graph[i, k] + graph[k, j];
					graph[i, j] = Math.Min(graph[i, j], cost);
				}
			}
		}

		//for (int i = 0; i < V; i++)
		//{
		//	for (int j = 0; j < V; j++)
		//	{
		//		Console.Write($"{graph[i, j]} ");
		//	}
		//	Console.WriteLine();
		//}

		int answer = MaxValue;
		for (int i = 0; i < V; i++)
		{
			for (int j = 0; j < V; j++)
			{
				if (i == j)
					continue;

				answer = Math.Min(answer, graph[i, j] + graph[j, i]);
			}
		}

		return answer == MaxValue ? -1 : answer;
	}
}

class Program
{
	static void Main(string[] args)
	{
		string[] ve = Console.ReadLine().Split(' ');
		int V = int.Parse(ve[0]);
		int E = int.Parse(ve[1]);

		int[, ] edges = new int[E, 3];
		for (int i = 0; i < E; i++)
		{
			string[] input = Console.ReadLine().Split(' ');
			edges[i, 0] = int.Parse(input[0]);
			edges[i, 1] = int.Parse(input[1]);
			edges[i, 2] = int.Parse(input[2]);
		}

		Solution solution = new Solution();
		int ret = solution.solution(V, E, edges);
		Console.WriteLine(ret);
	}
}



