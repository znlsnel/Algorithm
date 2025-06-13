using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
	public int solution(int H, int W, List<int> list)
	{
		int answer = 0;
		int maxH = 0;

		Stack<int> stack = new Stack<int> ();
		for (int i = 0; i < list.Count; i++)
		{
			int h = Math.Min(maxH, list[i]);

			Queue<int> temp = new Queue<int> ();
			while (stack.Count > 1 && stack.Peek() < list[i])
			{
				int value = stack.Peek();
				answer += Math.Max(0, h - value);
				stack.Pop();
				temp.Enqueue(list[i]); 
			}

			while (temp.Count > 0)
				stack.Push(temp.Dequeue()); 

			stack.Push(list[i]);
			maxH = Math.Max(maxH, list[i]);
		}
		return answer;
	}
}





class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		string[] inputs = Console.ReadLine().Split(' '); 
		int H = int.Parse(inputs[0]);
		int W = int.Parse(inputs[1]);

		List<int> list = new List<int>();
		Console.ReadLine().Split(' ').ToList().ForEach((str) => { list.Add(int.Parse(str));}); 


		int result = solution.solution(H, W, list);
		Console.WriteLine(result); 
	}
}

