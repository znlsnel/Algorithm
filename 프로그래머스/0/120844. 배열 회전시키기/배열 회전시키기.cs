using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        List<int> answer = new List<int>();
        foreach (int n in numbers)
            answer.Add(n);
        
        if (direction == "right")
        {
            int a = answer[answer.Count-1];
            answer.RemoveAt(answer.Count-1);
            answer.Insert(0, a);
        }
        else
        {
            int a = answer[0];
            answer.RemoveAt(0);
            answer.Add(a);
        }
        return answer.ToArray();
    }
}