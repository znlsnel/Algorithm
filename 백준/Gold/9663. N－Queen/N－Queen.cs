using System;
using System.Collections.Generic;
using System.Linq;

namespace Alroghtim_CS
{
	class Program
	{
		static int N;
		static int answer = 0;
		static List<(int, int)> pos = new List<(int, int)>();

		static bool CanReachDestination(int ay, int ax, int by, int bx)
		{
			if (ay == by)
				return true;
			if (ax == bx)
				return true;

			if (Math.Abs(ay - by) == Math.Abs(ax - bx))
				return true;

			return false;
		}


		static void Search(int y = 0)
		{
			if (pos.Count == N)
			{
				answer++;
				return;
			}

			for (int x = 0; x < N; x++)
			{
				bool flag = true;
				foreach ((int ay, int ax) in pos)
				{
					if (CanReachDestination(ay, ax, y, x))
					{
						flag = false;
						break;
					}
				}
				if (!flag) continue;

				pos.Add((y, x));
				Search(y + 1);
				pos.RemoveAt(pos.Count-1);
			}
		}


		static void Main(string[] args)
		{
			pos = new List<(int, int)>();
			answer = 0;
			N = int.Parse(Console.ReadLine());

			Search();

			Console.WriteLine(answer);
		}
	}
}

// 힌트 1
// 퀸은 좌, 우, 상, 하로 이동 할 수 있다!!

// 그렇기 때문에 퀸을 배치한 위치의 X값이 같으면 안되고 Y값이 같으면 안된다
// 그리고 대각선으로 이동할 수 있기 때문에

// 퀸 A의 위치 - 퀸 B의 위치의 x, y값의 절대값이 같으면 안된다~~

// [A] [  ] [  ]
// [  ] [  ] [  ]
// [  ] [  ] [B]