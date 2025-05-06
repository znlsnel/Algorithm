using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Solution
{
	public List<int> solution(int N, List<int> nums)
	{
		List<int> result = new List<int>();

		int maxValue = nums.Max();

		int[] dp = new int[maxValue+1];
		for (int i = 0; i < dp.Length; i++)
			dp[i] = 1;
		

		for (int i = 2; i < dp.Length; i++)
			dp[i] += dp[i - 2];

		for (int i = 3; i < dp.Length; i++)
			dp[i] += dp[i - 3];


		foreach (int idx in nums)
		{
			result.Add(dp[idx]);
		}
		return result;
	}
}

class Program
{
	static void Main(string[] args)
	{
		int N = int.Parse(Console.ReadLine());
		List<int> nums = new List<int>();
		for (int i = 0; i < N; i++)
		{
			int a = int.Parse((Console.ReadLine()));
			nums.Add(a);
		}

		Solution solution = new Solution();
		List<int> ret = solution.solution(N, nums);

		StringBuilder sb = new StringBuilder();
		foreach (int i in ret)
			sb.AppendLine(i.ToString());

		Console.WriteLine(sb.ToString());
	}
}



