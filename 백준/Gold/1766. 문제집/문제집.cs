using System;
using System.Collections.Generic;
using System.Text;

namespace Alroghtim_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] inDegree = new int[N + 1];
            List<int>[] graph = new List<int>[N + 1];
            
            for (int i = 1; i <= N; i++)
                graph[i] = new List<int>();

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split(' ');
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                // A번 문제는 B번 문제보다 먼저 풀어야 함
                graph[A].Add(B);
                inDegree[B]++;
            }

            // 진입차수가 0인 노드(먼저 풀 수 있는 문제)를 우선순위 큐에 넣음
            PriorityQueue pq = new PriorityQueue();
            for (int i = 1; i <= N; i++)
            {
                if (inDegree[i] == 0)
                    pq.Add(i);
            }

            StringBuilder sb = new StringBuilder();
            
            // 위상 정렬 수행
            while (!pq.IsEmpty())
            {
                int cur = pq.Pop();
                sb.Append(cur + " ");

                foreach (int next in graph[cur])
                {
                    inDegree[next]--;
                    if (inDegree[next] == 0)
                        pq.Add(next);
                }
            }

            // 마지막 공백 제거
            if (sb.Length > 0)
                sb.Length--;
                
            Console.WriteLine(sb.ToString());
        }
    }

    public class PriorityQueue
    {
        // 우선순위 큐 코드 (기존과 동일)
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
}