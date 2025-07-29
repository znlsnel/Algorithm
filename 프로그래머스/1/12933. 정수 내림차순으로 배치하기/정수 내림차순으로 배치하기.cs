using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        List<int> arr = new List<int>();
        
        while (n > 0)
        {
            arr.Add((int)(n % 10));
            n /= 10;
        }
        
        arr.Sort();

        for (int i = arr.Count-1; i >= 0; i--)
        {
            answer *= 10;
            answer += arr[i];
        }
        
        return answer;
        
    }
}