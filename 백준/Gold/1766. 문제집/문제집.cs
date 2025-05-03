using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Alroghtim_CS
{
	public class PriorityQueue
	{
		public void Add(int value)
		{
			arr[size++] = value;

			int cur = size - 1;

			while (cur > 0)
			{
				int parent = (cur - 1) / 2;

				if (arr[parent] > arr[cur])
				{
					int temp = arr[cur];
					arr[cur] = arr[parent];
					arr[parent] = temp;

					cur = parent;
				}
				else
					break;
			}
		}



		public int Pop()
		{
			int ret = arr[0];
			arr[0] = arr[--size];

			int cur = 0;

			while (cur < size - 1)
			{
				int left = cur * 2 + 1;
				int right = left + 1;

				if (left >= size)
					break;

				if (right < size && arr[right] < arr[left])
					left = right;

				if (arr[left] < arr[cur])
				{
					int temp = arr[left];
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
		public int Count() => size;

		int size = 0;
		int[] arr = new int[100000];
	}

	class Program
	{
		static int N;
		static int M;

		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');
			int N = int.Parse(input[0]);
			int M = int.Parse(input[1]);

			int[] inDegree = new int[N + 1];
			List<int>[] outDegree = new List<int>[N + 1];
			for (int i = 1; i <= N; i++)
				outDegree[i] = new List<int>();


			for (int i = 0; i < M; i++)
			{
				input = Console.ReadLine().Split(' ');
				int A = int.Parse(input[0]);
				int B = int.Parse(input[1]);

				inDegree[B]++;
				outDegree[A].Add(B);
			}

			StringBuilder sb = new StringBuilder();

			PriorityQueue pq = new PriorityQueue();

			for (int i = 1; i <= N; i++)
			{
				if (inDegree[i] == 0)
					pq.Add(i);
			}

			while (!pq.IsEmpty())
			{
				int cur = pq.Pop();
				sb.Append(cur + " ");
				
				foreach (int nxt in outDegree[cur])
				{
					inDegree[nxt]--;
					if (inDegree[nxt] == 0)
						pq.Add(nxt);
				}
			}
			sb = sb.Remove(sb.Length - 1, 1);
			string ret = sb.ToString();
			Console.WriteLine(ret);
		}

	}


}
