using System;
using System.Collections.Generic;
using System.Text;

public class PriorityQueue
{
    public void Add(int num)
    {
        arr[size++] = num;
        int cur = size-1;
        
        while (cur > 0)
        {
            int parent = (cur -1) / 2;
            if (Comp(arr[cur], arr[parent]))
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
            int right = left+1;
            
            if (left >= size)
                break;
            
            if (right < size && Comp(arr[right], arr[left]))
                left = right;
                
            if (Comp(arr[left], arr[cur]))
            {
                int temp = arr[cur];
                arr[cur] = arr[left];
                arr[left] = temp;
                cur = left;
            }
            else
                break;
        }
        return ret;
    }
    
    private bool Comp(int a, int b)
    {        
        int A = int.Parse(a.ToString() + b.ToString());
        int B = int.Parse(b.ToString() + a.ToString());
        
        return A > B;
    }
    
    public bool isEmpty => size == 0;
    
    int size = 0;
    int[] arr = new int[200001];
}

public class Solution 
{
    public string solution(int[] numbers) 
    {
        StringBuilder sb = new StringBuilder();
        PriorityQueue pq = new PriorityQueue();
        string answer = "";
        
        foreach (int n in numbers)
            pq.Add(n); 
        
        while (!pq.isEmpty)
            sb.Append(pq.Pop().ToString());
        
        answer = sb.ToString();

        foreach (var item in answer)
            if (item != '0')
                return answer;
        
        
        return "0";
    }
}