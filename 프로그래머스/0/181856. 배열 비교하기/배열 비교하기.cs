using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int size1 = 0;
        int size2 = 0;
        foreach (int n in arr1)
            size1 += n;
        foreach (int n in arr2)
            size2 += n;
        
        if (arr1.Length > arr2.Length)
            return 1;
        else if (arr1.Length < arr2.Length)
            return -1;
        
        return size1 > size2 ? 1 : size1 < size2 ? -1 : 0;
    }
}