using System;
using System.Collections.Generic;

public class Program
{
	static int Main(string[] args)
	{

		string A = Console.ReadLine();
		string B = Console.ReadLine();
		int C = int.Parse(Console.ReadLine());


		//Solution solution = new Solution();
		//List<int> ret = solution.solution(N, X, arr);
		Console.WriteLine(int.Parse(A) + int.Parse(B) - C);
		Console.WriteLine(int.Parse(A + B) - C);
		return 0;
	}
}
