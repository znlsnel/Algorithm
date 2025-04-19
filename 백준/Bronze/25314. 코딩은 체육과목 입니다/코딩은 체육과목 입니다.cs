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
			int size = int.Parse(Console.ReadLine());
			
			while (size > 0)
			{
				size -= 4;
				Console.Write("long ");
			}
			Console.Write("int");

		}
	}
}

// 
// 2 0 0 
// 0 1 1


