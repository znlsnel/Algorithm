using System;
using System.Collections.Generic;


class Solution
{
	public List<int> solution(int N, int X, List<int> arr)
	{
		List<int> ret = new List<int>();
		foreach (int x in arr)
		{
			if (x < X)
				ret.Add(x);
		}

		return ret;
	}

}



public class Program
{
	static int Main(string[] args)
	{
		string[] inputs = Console.ReadLine().Split(' ');
		int N = int.Parse(inputs[0]);
		int X = int.Parse(inputs[1]);

		inputs = Console.ReadLine().Split(' ');
		List<int> arr = new List<int>();
		for (int i = 0; i < N; i++)
		{
			arr.Add(int.Parse(inputs[i]));
		}

		Solution solution = new Solution();
		List<int> ret = solution.solution(N, X, arr);
		Console.WriteLine(string.Join(" ", ret));
		return 0;
	}
}
