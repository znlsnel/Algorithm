using System;
using System.Collections.Generic;


class Solution
{
	public int solution(int C, int N, List<(int, int)> arr)
	{
		int[] costs = new int[100001];
		foreach (var (c, a) in arr)
		{
			for (int j = 1; j <= 100000; j++)
			{
				if (j - c >= 0)
				{
					costs[j] = Math.Max(costs[j], costs[j - c] + a);
				}
			}
		}

		int answer = 0;
		for (int i = 0; i < costs.Length; i++)
			if (costs[i] >= C)
				return i;

		return -1;
	}

}



public class Program
{
	static int Main(string[] args)
	{
		string[] inputs = Console.ReadLine().Split(' ');
		int C = int.Parse(inputs[0]);
		int N = int.Parse(inputs[1]);

		List<(int, int)> arr = new List<(int, int)> ();
		for (int i = 0; i < N; i++)
		{
			inputs = Console.ReadLine().Split(' ');
			int c = int.Parse(inputs[0]);
			int n = int.Parse(inputs[1]);

			arr.Add((c, n));
		}
		
		Solution solution = new Solution();
		var ret = solution.solution(C, N, arr);
		Console.WriteLine(ret);
		return 0;
	}
}
