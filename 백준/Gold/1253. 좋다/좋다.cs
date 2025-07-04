using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
	public int solution(List<int> nums)
	{
		int answer = 0;

		nums.Sort();

		for (int i = 0; i < nums.Count; i++)
		{
			int left = 0;
			int right = nums.Count - 1;

			int target = nums[i];

			while (left < right)
			{
				int sum = nums[left] + nums[right];
				if (left == i || sum < target)
					left++;

				else if (right == i || sum > target)
					right--; 

				else if (sum == target)
				{
					answer++;
					break;
				}

			}
		}

		return answer;
	}
}


class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		int N = int.Parse(Console.ReadLine());
		List<int> list = new List<int>();
		string[] inputs = Console.ReadLine().Split(' ');

		for (int i = 0; i < N; i++)
		{
			int num = int.Parse(inputs[i]);
			list.Add(num);
		}


		Console.WriteLine(solution.solution(list));

	}
}

