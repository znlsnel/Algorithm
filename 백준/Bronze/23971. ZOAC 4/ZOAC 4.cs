using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Solution
{

	public int solution(int H, int W, int N, int M)
	{
		int width = 0, height = 0;

		int cnt = 0;
		for (int i = 0; i < W; i++ )
		{
			if (cnt++ == 0)
				width++;

			cnt %= M + 1;
		}

		cnt = 0;
		for (int i = 0; i < H; i++)
		{
			if (cnt++ == 0)
				height++;

			cnt %= N + 1;
		}

		return width * height;
	}
}

class Program
{
	static void Main(string[] args)
	{
		string[] inputs = Console.ReadLine().Split(' ');
		int H = int.Parse(inputs[0]);
		int W = int.Parse(inputs[1]);
		int N = int.Parse(inputs[2]);
		int M = int.Parse(inputs[3]);

		Solution solution = new Solution();
		Console.WriteLine(solution.solution(H, W, N, M)); 
	}
}