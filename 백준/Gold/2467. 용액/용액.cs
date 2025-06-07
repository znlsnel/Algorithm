using System;
using System.Collections.Generic;


class Solution
{
	public (int, int) solution(int N, int[] arr)
	{
		(int, int) answer = (0, 0);
		int minValue = int.MaxValue;

		Array.Sort(arr);

		int left = 0;
		int right = N - 1;

		while (left < right)
		{
			int value = arr[left] + arr[right];
			if (Math.Abs(value) <= minValue)
			{
				answer = (arr[left], arr[right]);
                minValue = Math.Abs(value);
			}
			
			if (value > 0)
				right--;
			else
				left++;
		}


		return answer;
	}

}



public class Program
{
	static int Main(string[] args)
	{

		int N = int.Parse(Console.ReadLine());
		string[] inputs = Console.ReadLine().Split(' ');
		int[] arr = new int[N];

		int idx = 0;
		foreach (string str in inputs)
			arr[idx++] = int.Parse(str);
		
		Solution solution = new Solution();
		var ret = solution.solution(N, arr);
		Console.WriteLine($"{ret.Item1}, {ret.Item2}");
		return 0;
	}
}
