using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{ 
	public int solution(int N)
	{
		if (N == 1)
			return 0;

		int answer = 0;

		bool[] visited = new bool[N+1];
		
		for (int i = 2; i * i <= N; i++)
		{
			if (visited[i])
				continue;

			int num = i * 2;
			while (num <= N)
			{
				visited[num] = true;
				num += i;
			}
		}

		List<int> primNums = new List<int>();
		for (int i = 2; i <= N; i++)
		{
			if (visited[i] == false)
				primNums.Add(i);
		}

		int left = 0;
		int right = 0;

		int total = primNums[0];

		while (left <= right)
		{
			if (total > N)
				total -= primNums[left++]; 
			else
			{
				if (total == N)
					answer++;
				right++;

				if (right >= primNums.Count)
					break;

				total += primNums[right];
			}
		}

		return answer;
	}
}





class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		int N = int.Parse(Console.ReadLine()); 
		Console.WriteLine(solution.solution(N));
	}
}

