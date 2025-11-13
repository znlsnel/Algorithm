using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        List<int> list = new List<int>();
        
        Array.Sort(num_list);
        for (int i = 0; i < 5; i++)
        {
            list.Add(num_list[i]);
        }
        return list.ToArray();
    }
}