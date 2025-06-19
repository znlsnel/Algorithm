using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
	private Dictionary<int, string> dic = new Dictionary<int, string>()
	{
		{0, "1110111"},
		{1 , "0010001"},
		{2 , "0111110"},
		{3 , "0111011"},
		{4 , "1011001"},
		{5 , "1101011"},
		{6 , "1101111"}, 
		{7 , "0110001"},
		{8 , "1111111"},
		{9 , "1111011"},
	};

	public int solution(int N, int K, int P, int X)
	{
		int ret = 0;
		for (int i = 1; i <= N; i++)
		{
			if (i == X)
				continue;

			int cnt = 0;
			int from = X, to = i;

			for (int j = 0; j < K; j++)
			{
				for (int z = 0; z < 7; z++)
				{
					if (dic[from%10][z] != dic[to%10][z]) 
						cnt++;
				}
				from /= 10;
				to /= 10;
			}

			if (cnt <= P)
				ret++;
		}

		return ret;
	}
}


class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();
		
		string[] inputs = Console.ReadLine().Split(' ');
		int N = int.Parse(inputs[0]);
		int K = int.Parse(inputs[1]);
		int P = int.Parse(inputs[2]);
		int X = int.Parse(inputs[3]);

		Console.WriteLine(solution.solution(N, K, P, X));
	}
}

