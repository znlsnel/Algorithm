using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
	public List<int> solution(string str, int K)
	{
		Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>();
		int minLen = int.MaxValue;
		int maxLen = int.MinValue;

		for (int i = 0; i < str.Length; i++)
		{
			char c = str[i];
			if (!dic.ContainsKey(c))
				dic.Add(c, new List<int>());

			dic[c].Add(i);
		}
		
		foreach (var tuple in dic.ToArray())
		{
			if (tuple.Value.Count < K)
				dic.Remove(tuple.Key);
		}

		foreach (var tuple in dic.ToArray())
		{
			for (int i = 0; i < tuple.Value.Count; i++)
			{
				int j = i + (K - 1);
				if (j >= tuple.Value.Count) 
					continue;

				int s = tuple.Value[i];
				int e = tuple.Value[j];

				minLen = Math.Min(e - s + 1, minLen);
				maxLen = Math.Max(e - s + 1, maxLen);
				
			}
		}

		if (minLen == int.MaxValue)
			return new List<int>() { -1 };
		else
			return new List<int>() { minLen, maxLen };
	}
}





class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();
		int N = int.Parse(Console.ReadLine());
		
		while (N-- > 0)
		{
			string str = Console.ReadLine();
			int K = int.Parse(Console.ReadLine());
		
			List<int> result = solution.solution(str, K);
			Console.WriteLine(string.Join(" ", result));  
		}
	}
}