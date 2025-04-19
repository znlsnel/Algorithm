using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Alroghtim_CS
{
	class Program
	{
		static void Main(string[] args)
		{
			int total = int.Parse(Console.ReadLine());
			int N = int.Parse(Console.ReadLine());
			for (int i = 0; i < N; i++)
			{
				string[] input = Console.ReadLine().Split();
				int A = int.Parse(input[0]);
				int B = int.Parse(input[1]);

				total -= A * B;
			}

			if (total == 0)
				Console.WriteLine("Yes");
			else 
				Console.WriteLine("No");
		}
	}
}

// 
// 2 0 0 
// 0 1 1


