using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{

	private bool Find(List<int> list,  HashSet<int> idxs, HashSet<int> nums , int idx)
	{
		int nxt = list[idx - 1];
		
		if (idxs.Contains(idx))
			return idxs.Count() == nums.Count();

		idxs.Add(idx);
		nums.Add(nxt);

		return Find(list, idxs, nums, nxt);
	}
	 

	public List<int> solution(List<int> list)
	{ 
		bool[] visited = new bool[list.Count];

		HashSet<int> ret = new HashSet<int>();
		
		for (int i = 1; i <= list.Count; i++)
		{
			if (visited[i - 1])
				continue;

			HashSet<int> idxs = new HashSet<int>();
			HashSet<int> nums = new HashSet<int>();
			if (Find(list, idxs, nums, i))
			{
				foreach (var idx in idxs)
				{
					ret.Add(idx);
					visited[idx - 1] = true;
				}
			}
		}

		for (int i = 0; i < list.Count; i++)
		{
			if (i+1 == list[i])
				ret.Add(i+1);
		} 

		List<int> answer = ret.ToList();
		answer.Sort();
		return answer;  
	}
}


class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();
		List<int> list = new List<int>();

		int N = int.Parse(Console.ReadLine());

		while (N-- > 0)
		{
			int num = int.Parse(Console.ReadLine());
			list.Add(num);
		} 

		List<int> ret = solution.solution(list);
		Console.WriteLine(ret.Count);
		Console.WriteLine(string.Join("\n", ret));
	}
}

