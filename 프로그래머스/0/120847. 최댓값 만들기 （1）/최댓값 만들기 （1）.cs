using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        Array.Sort(numbers);
    
        int cnt = numbers.Length - 1;
        return numbers[cnt] * numbers[cnt-1];
    }
}