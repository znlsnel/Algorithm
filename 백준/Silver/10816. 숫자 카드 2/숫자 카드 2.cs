using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alroghtim_CS
{
	class Program
	{
		static StringBuilder sb = new StringBuilder();

		static void Main(string[] args)
		{
			List<int> nums = new List<int>();
			List<int> cards = new List<int>();

			int N = int.Parse(Console.ReadLine());
			string[] nums_str = Console.ReadLine().Split(' ');
			
			int M = int.Parse(Console.ReadLine());
			string[] nums_strM = Console.ReadLine().Split(' ');


			for (int i = 0; i < N; i++)
				nums.Add(int.Parse(nums_str[i]));

			for (int i = 0; i < M; i++)
				cards.Add(int.Parse(nums_strM[i]));

			nums.Sort();

			int[] answer = new int[cards.Count];
			for (int i = 0; i < cards.Count; i++ )
			{
				int target = cards[i];
				int start = 0;
				int end = nums.Count - 1;

				while (start <= end)
				{
					int mid = (start + end) / 2;

					if (nums[mid] > target)
						end = mid -1;
					else
						start = mid + 1;
				}
				int A = start;


				start = 0;
				end = nums.Count - 1;
				while (start <= end)
				{
					int mid = (start + end) / 2;

					if (nums[mid] < target)
						start = mid + 1;
					else
						end = mid - 1;
				}
				int B = start;

				answer[i] = A - B;

			}

			for (int i = 0; i < answer.Length -1 ; i++)
				sb.Append(answer[i] + " ");
			sb.Append(answer[answer.Length - 1]);

			Console.Write(sb.ToString()); 
		}

	}
}

// 이 문제의 어려운점은 아래의 힌트를 어떻게 찾을것인가 ?? ? ? ?? 


// 힌트 1
// 퀸은 좌, 우, 상, 하로 이동 할 수 있다!!

// 그렇기 때문에 퀸을 배치한 위치의 X값이 같으면 안되고 Y값이 같으면 안된다
// 그리고 대각선으로 이동할 수 있기 때문에

// 퀸 A의 위치 - 퀸 B의 위치의 x, y값의 절대값이 같으면 안된다~~

// [A] [  ] [  ]
// [  ] [  ] [  ]
// [  ] [  ] [B]