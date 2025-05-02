using System;
using System.Collections.Generic;
using System.Text;



public class Solution 
{
    public void QuickSort(int[] arr, int l, int r)
    {
        if (l >= r)
            return;
        
        int pivot = Partition(arr, l, r);
                
        QuickSort(arr, l, pivot - 1);
        QuickSort(arr, pivot + 1, r);
    }
    

    private int Partition(int[] arr, int l, int r)
    {
        int p = arr[l]; // 피벗 값 (첫 번째 요소)
        int i = l + 1;  // 왼쪽에서 시작하는 포인터
        int j = r;      // 오른쪽에서 시작하는 포인터

        while (true)
        {
            // 피벗보다 큰 요소 찾기 (i 증가)
            while (i <= j && Comp(arr[i], p))
                i++;

            // 피벗보다 작거나 같은 요소 찾기 (j 감소)
            while (i <= j && Comp(p, arr[j]))
                j--;

            // 포인터가 교차하면 루프 종료
            if (i > j)
                break;

            // arr[i]와 arr[j] 교환
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            i++;
            j--;
        }

        // 피벗을 올바른 위치로 이동
        int pivotTemp = arr[l];
        arr[l] = arr[j];
        arr[j] = pivotTemp;

        // 피벗의 최종 위치 반환
        return j;
    }
    
    
    private bool Comp(int a, int b)
    {
        int A = int.Parse(a.ToString() + b.ToString());
        int B = int.Parse(b.ToString() + a.ToString());
        
        return A > B;
    }
    
    public string solution(int[] numbers) 
    {
       // StringBuilder sb = new StringBuilder();
        QuickSort(numbers, 0, numbers.Length-1);
        
        string answer = "";
        
       // foreach (int num in numbers)
       //     sb.Append(num.ToString());
        
        answer = string.Join(string.Empty, numbers);
        
        foreach (char c in answer)
        {
            if (c != '0')
                return answer;
        }
        
        return "0";
    }
}