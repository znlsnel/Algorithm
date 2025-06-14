using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PriorityQueue<T>
{
	public Func<T, T, bool> comp;

	public PriorityQueue(Func<T, T, bool> cmp)  
	{
		comp = cmp;
	}

	public void Add(T item)
	{
		if (arr.Count > size)
			arr[size] = item;
		else
			arr.Add(item);

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
	List<T> arr = new List<T>();
}



public class Solution
{
	List<(int, int)>[] roads;
	private int Dijkstra()
	{
		int[] costs = new int[roads.Length];
		for (int i = 0; i < costs.Length; i++)
			costs[i] = int.MaxValue;

		PriorityQueue<(int, int)> pq = new PriorityQueue<(int, int)>((a, b) => { return a.Item2 < b.Item2; });
		pq.Add((1, 0));


		while(!pq.IsEmpty())
		{
			var (node, cost) = pq.Pop();
			
			foreach (var (nxt, nCost) in roads[node])
			{
				if (costs[nxt] <= cost + nCost)
					continue;

				pq.Add((nxt, cost + nCost));
				costs[nxt] = cost + nCost;
			}
		}

		return costs[roads.Length-1];
	}

	public int solution(int N, int M, List<(int, int, int)> list)
	{
		roads = new List<(int, int)>[N+1];
		for (int i = 0; i <= N; i++)
			roads[i] = new List<(int, int)>(); 

		foreach (var (a, b, c) in list)
		{
			roads[a].Add((b, c)); 
			roads[b].Add((a, c)); 
		}

		return Dijkstra();
	}
}





class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		string[] inputs = Console.ReadLine().Split(' '); 
		int N = int.Parse(inputs[0]);
		int M = int.Parse(inputs[1]);

		List<(int, int, int)> list = new List<(int, int, int)>();
		for (int i = 0; i < M; i++)
		{
			inputs = Console.ReadLine().Split(' ');
			int A = int.Parse(inputs[0]);
			int B = int.Parse(inputs[1]);
			int C = int.Parse(inputs[2]);

			list.Add((A, B, C));
		}

		Console.WriteLine(solution.solution(N, M, list));
	}
}

