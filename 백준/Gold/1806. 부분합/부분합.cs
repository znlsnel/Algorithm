using System;
using System.Collections.Generic;


class Solution
{
	public int solution(int N, int S, int[] arr)
	{

		int left = 0;
		int right = 0;
		int total = arr[0];
		int answer = int.MaxValue;

		while (left <= right && right < N)
		{
			if (total >= S)
			{
				answer = Math.Min(answer, right - left + 1);
				total -= arr[left++];
			}
			else
			{
				right++;
				if (right == N)
					continue;

				total += arr[right];
			}
			
		}



		return answer == int.MaxValue ? 0 : answer;
	}

}



public class Program
{
	static int Main(string[] args)
	{
		string[] inputs = Console.ReadLine().Split(' ');
		int N = int.Parse(inputs[0]);
		int S = int.Parse(inputs[1]);

		inputs = Console.ReadLine().Split(' ');
		int[] arr = new int[N];

		for (int i = 0; i < inputs.Length; i++)
			arr[i] = int.Parse(inputs[i]);
		

		Solution solution = new Solution();
		var ret = solution.solution(N, S, arr);
		Console.WriteLine(ret);
		return 0;
	}
}
