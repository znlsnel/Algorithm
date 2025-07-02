using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{
	public int solution(int n, List<(int, int)> points)
	{
		int answer = 0;

		Stack<(int, int)> stack = new Stack<(int, int)> ();

		for (int i = 0; i < n; i++)
		{
			int nxt = points[i].Item2;

			while (stack.Count > 0 && stack.Peek().Item2 > nxt)
			{
				answer++;
				stack.Pop();
			}

			if (nxt == 0 || stack.Count > 0 && stack.Peek().Item2 == nxt)
				continue;

			stack.Push(points[i]); 
		}
		

		return answer + stack.Count;
	}
}


class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		int N = int.Parse(Console.ReadLine());
		
		List<(int, int)> list = new List<(int, int)> ();
		for (int i = 0; i < N; i++)
		{
			string[] inputs = Console.ReadLine().Split (' ');
			int A = int.Parse(inputs[0]);
			int B = int.Parse(inputs[1]);
			list.Add((A, B));
		}

		Console.WriteLine(solution.solution(N, list));
	}
}

