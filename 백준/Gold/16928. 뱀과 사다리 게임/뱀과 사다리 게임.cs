using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Solution
{
	private int Dijkstra(int[] graph)
	{
		int[] costs = new int[101];
		for (int i = 0; i < costs.Length; i++)
			costs[i] = int.MaxValue;

		Func<(int, int), (int, int), bool> comp = (a, b) =>
		{
			if (a.Item2 == b.Item2)
				return a.Item1 > b.Item1;

			return a.Item2 < b.Item2;
		};

		PriorityQueue<(int, int)> pq = new PriorityQueue<(int, int)>(comp);
		pq.Add((1, 0));
		costs[1] = 0;

		while (!pq.IsEmpty())
		{
			(int, int) value = pq.Pop();
			int pos = value.Item1;
			int cost = value.Item2;

			if (pos == 100)
				return cost;

			for (int i = 1; i <= 6; i++)
			{
				int nxt = pos + i;
				if (nxt > 100)
					break;

				nxt = graph[nxt];

				if (costs[nxt] <= cost + 1)
					continue;

				pq.Add((nxt, cost + 1));
                costs[nxt] = cost + 1; 
			}
		}

		return 1;
	}

	public int solution(List<(int, int)> ladder, List<(int, int)> snake)
	{
		int[] graph = new int[101];

		for (int i = 0; i < graph.Length; i++)
			graph[i] = i;

		for (int i = 0; i < ladder.Count; i++)
			graph[ladder[i].Item1] = ladder[i].Item2;
		
		for (int i = 0; i < snake.Count; i++)
			graph[snake[i].Item1] = snake[i].Item2;

		return Dijkstra(graph); 
	}
}





public class PriorityQueue<T>
{
	public Func<T, T, bool> comp;

	public PriorityQueue(Func<T, T, bool> cmp, int Size = 10000000)
	{
		comp = cmp;
		arr = new T[Size];
	}

	public void Add(T item)
	{
		arr[size] = item;

		int cur = size++;

		while (cur > 0)
		{
			int parent = (cur - 1) / 2;

			if (comp(arr[cur], arr[parent]))
			{
				T temp = arr[cur];
				arr[cur] = arr[parent];
				arr[parent] = temp;
				cur = parent;
			}
			else
				break;
		}
	}

	public T Pop()
	{
		T ret = arr[0];
		arr[0] = arr[--size];

		int cur = 0;

		while (cur < size)
		{
			int left = (cur * 2) + 1;
			int right = left + 1;

			if (left >= size)
				break;

			if (right < size && comp(arr[right], arr[left]))
				left = right;

			if (comp(arr[left], arr[cur]))
			{
				T temp = arr[left];
				arr[left] = arr[cur];
				arr[cur] = temp;
				cur = left;
			}
			else
				break;
		}

		return ret;
	}

	public bool IsEmpty() => size == 0;

	int size = 0;
	T[] arr;
}

class Program
{
	static void Main(string[] args)
	{
		string[] inputs = Console.ReadLine().Split(' ');
		int N = int.Parse(inputs[0]);
		int M = int.Parse(inputs[1]);

		List<(int, int)> ladder = new List<(int, int)> ();
		List<(int, int)> snake = new List<(int, int)> ();

		for (int i = 0; i < N + M; i++)
		{
			string[] edge = Console.ReadLine().Split(' ');
			int from = int.Parse(edge[0]);
			int to = int.Parse(edge[1]);

			if (i < N)
				ladder.Add((from, to));
			else
				snake.Add((from, to)); 
		}	

		Solution solution = new Solution();
		Console.WriteLine(solution.solution(ladder, snake));  
	}
}