using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
	int[,] country;
	bool[,] visited;
	int N, L, R;

	int[] dy = new int[] { 1, -1, 0, 0 };
	int[] dx = new int[] { 0, 0, 1, -1 };

	private void DFS(int y, int x, List<(int, int)> asso, ref int total)
	{
		visited[y, x] = true;
		asso.Add((y, x));
		int amount = country[y, x];
		total += amount;

		for (int i = 0; i < 4; i++)
		{
			int ny = y + dy[i];
			int nx = x + dx[i];

			if (ny < 0 || ny >= N || nx < 0 || nx >= N || visited[ny, nx])
				continue;

			int na = country[ny, nx];
			int diff = Math.Abs(amount - na);

			if (diff < L || diff > R)
				continue;

			DFS(ny, nx, asso, ref total);
		}
	}

	public bool solution(int[, ] list, int l, int r)
	{
		bool ret = false;

		this.country = list;
		N = list.GetLength(0);
		visited = new bool[N, N];
		L = l; R = r;

		for (int i = 0; i < list.GetLength(0); i++)
		{
			for (int j = 0; j < list.GetLength(1); j++)
			{
				if (visited[i, j] == true)
					continue;

				List<(int, int)> asso = new List<(int, int)>();
				int total = 0;
				DFS(i, j, asso, ref total);

				if (ret == false && asso.Count > 1)
					ret = true;

				foreach (var (y, x) in asso)
				{
					country[y, x] = total / asso.Count;
				}
			}
		}

		return ret;
	}
}


class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		string[] inputs = Console.ReadLine().Split(' ');
		int N = int.Parse(inputs[0]);
		int L = int.Parse(inputs[1]);
		int R = int.Parse(inputs[2]);

		int[,] country = new int[N, N];

		for (int i = 0; i < N; i++)
		{
			inputs = Console.ReadLine().Split(' ');
			for (int j = 0; j < N; j++)
				country[i, j] = int.Parse(inputs[j]);
			
		}

		int answer = 0;
		while (solution.solution(country, L, R) == true)
			answer++;
		

		Console.WriteLine(answer);
	}
}

