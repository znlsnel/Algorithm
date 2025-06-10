using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
	public List<int> solution(List<int> arr)
	{
		List<int> result = new List<int>();

		Stack<(int, int)> stack = new Stack<(int, int)> ();

		for (int i = 0; i < arr.Count; i++)
		{
			int num = arr[i];
			int ret = 0;

			while (stack.Count > 0 && stack.Peek().Item2 < num)
				stack.Pop();

			if (stack.Count > 0)
				ret = stack.Peek().Item1;

			result.Add(ret);
			stack.Push((i + 1, arr[i]));
		}

		return result;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();
		int N = int.Parse(Console.ReadLine());
		List<int> list = new List<int>();

		string[] inputs = Console.ReadLine().Split(' ');
		foreach (string c in inputs)
			list.Add(int.Parse(c));

		List<int> result = solution.solution(list);
		Console.WriteLine(string.Join(" ", result)); 
	}
}

