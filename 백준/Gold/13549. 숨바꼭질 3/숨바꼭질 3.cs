using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class PriorityQueue<T>
{
	public Func<T, T, bool> comp;

	public PriorityQueue(Func<T, T, bool> cmp, int Size = 1000000)
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



public class Solution
{
	int K;
	public bool Comp((int, int)a, (int, int) b)
	{
		int dist1 = Math.Abs(K - a.Item1);
		int dist2 = Math.Abs(K - b.Item1);

		if (a.Item2 == b.Item2)
			return dist1 < dist2;

		return a.Item2 < b.Item2;
	} 
	 
	public int solution(int N, int K)
	{
		this.K = K;

		int[] distance = new int[200001];
		for (int i = 0; i < 200001; i++)
			distance[i] = int.MaxValue;

		PriorityQueue<(int, int)> costs = new PriorityQueue<(int, int)>(Comp, 1000000);
		costs.Add((N, 0));

		while(costs.IsEmpty() == false) 
		{
			(int pos, int cost ) = costs.Pop();

			if (pos == K) 
			{
				return cost;
			}

			int front = pos + 1;
			int back = pos - 1;
			int jump = pos * 2;

			if (front >= 0 && front <= 100000 && distance[front] > cost + 1)
			{
				costs.Add((front, cost + 1));
				distance[front] = cost + 1;
			}

			if (back >= 0 && back <= 100000 && distance[back] > cost + 1)
			{
				costs.Add((back, cost + 1));
				distance[back] = cost + 1;
			}

			if (jump >= 0 && jump <= 100000 && distance[jump] > cost && pos < K)
			{
				costs.Add((jump, cost));
				distance[jump] = cost;

			}
		}

		return -1;
	}
}

class Program
{
	static void Main(string[] args)
	{
		string[] input = Console.ReadLine().Split(' ');
		int N = int.Parse(input[0]);
		int K = int.Parse(input[1]);

		Solution solution = new Solution();
		Console.WriteLine(solution.solution(N, K));
	}
}



