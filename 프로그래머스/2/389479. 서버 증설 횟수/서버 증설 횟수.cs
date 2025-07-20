using System;

public class PQ
{
    public void Add(int num)
    {
        arr[size++] = num;
        
        int cur = size-1;
        
        while (cur > 0)
        {
            int parent = (cur-1) / 2;
            if (arr[cur] < arr[parent])
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
        
        while (cur < size)
        {
            int left = cur * 2 + 1;
            int right = left + 1;
            
            if (right < size && arr[left] > arr[right])
                left = right;
            
            if (left < size && arr[left] < arr[cur])
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
    
    public bool IsEmpty => size == 0;
    public int Size => size;
    int size = 0;
    int[] arr = new int[100000];
}

public class Solution {
    public int solution(int[] players, int m, int k) {
        int answer = 0;
        
        PQ pq = new PQ();
        
        foreach (int p in players)
        {
            int[] arr = new int[pq.Size];
            int idx = 0;
            while (!pq.IsEmpty)
            {
                int n = pq.Pop();
                if (n > 1)
                    arr[idx++] = n-1;
            }
            
            foreach (int num in arr){
                if (num == 0)
                    continue;
                pq.Add(num);
                
            }
            
            int server = pq.Size;
            
            if (p / m > server)
            {
                int cnt = p / m - server;
                while (cnt-- > 0)
                {
                    pq.Add(k);
                    answer++;
                }
            }
        }
        
        
        return answer;
    }
}