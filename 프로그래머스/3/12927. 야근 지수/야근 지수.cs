using System;
using System.Collections.Generic;

public class PriorityQueue
{
    // 0
    // 1 2 
    // 34 56
    public void Add(int value)
    {
        arr[size++] = value;
        
        int cur = size-1;
        
        while (cur > 0)
        {
            int parent = (cur - 1) / 2;
            
            if (arr[parent] < arr[cur])
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
        
        while (cur < size-1)
        {
            int left = cur * 2 + 1;
            int right = left+1;
            
            if (left >= size)
                break;
            
            if (right < size && arr[right] > arr[left])
                left = right;
            
            if (arr[left] > arr[cur])
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
    
    
    int size = 0;
    int[] arr = new int[30000];
}

public class Solution 
{
    
    public long solution(int n, int[] works) 
    {
        long answer = 0;
        PriorityQueue pq = new PriorityQueue();

        foreach (int work in works)
            pq.Add(work);
            
        while (n-- > 0 && !pq.IsEmpty())
        {
            int cur = pq.Pop();
       //     Console.WriteLine($"정리 : {cur}");
            
            pq.Add(Math.Max(0, cur-1)); 
        }
        
        while (!pq.IsEmpty())
        {
            int value = pq.Pop();
         //   Console.WriteLine($"나머지 : {value}");
            answer += (long)value * (long)value;
        }
        
        return answer;
    }
}

// 야근 피로도 = 야근을 시작한 시점에서 남은 일의 작업량을 제곱하여 더한 값
// 