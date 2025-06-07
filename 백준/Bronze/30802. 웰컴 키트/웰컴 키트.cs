using System;
using System.Collections.Generic;

public class Program
{
	static int Main(string[] args)
	{

		int N = int.Parse(Console.ReadLine());
		string[] sizes = Console.ReadLine().Split(' ');
		string[] inputs = Console.ReadLine().Split(' ');

		int T = int.Parse(inputs[0]);
		int P = int.Parse(inputs[1]);


		//Solution solution = new Solution();
		//List<int> ret = solution.solution(N, X, arr);

		int Tbundle = 0;
		for (int i = 0; i <  sizes.Length; i++)
		{
			int num = int.Parse(sizes[i]);
			Tbundle += ((num + T - 1) / T);
		}

		int Pbundle = N / P;
		int left = N % P;

		Console.WriteLine(Tbundle);
		Console.WriteLine($"{Pbundle} {left}");
		


		return 0;
	}
}
