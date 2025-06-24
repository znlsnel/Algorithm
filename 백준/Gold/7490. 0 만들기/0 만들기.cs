using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{
	int N;

	private void DFS(List<string> answer, string str, int num, int total)
	{
		if (num >= N+1)
		{
			if (num == N + 1 && total == 0)
				answer.Add(str);
			return;
		}

		DFS(answer, str + "+" + num, num + 1, total + num);
		DFS(answer, str + "-" + num, num + 1, total - num);

		if (num < N)
		{
			int nxt = num * 10 + (num + 1);
			DFS(answer, str + "+" + num + " " + (num+1), num + 2, total + nxt);
			DFS(answer, str + "-" + num + " " + (num+1), num + 2, total - nxt);  
		}
	}

	public string solution(int n)
	{
		N = n;
		List<string> answer = new List<string>();
		DFS(answer, "1", 2, 1);
		DFS(answer, "1 2", 3, 12);

		answer.Sort();

		return string.Join("\n", answer);
	}
}


class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();
		int cnt = int.Parse(Console.ReadLine());

		List<string> answer = new List<string>();

		while (cnt-- > 0)
		{
			int N = int.Parse(Console.ReadLine());
			answer.Add(solution.solution(N));
		}

		Console.WriteLine(string.Join("\n\n", answer)); 
	}
}

