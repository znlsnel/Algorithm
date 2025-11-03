using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b, int c) {
     
        HashSet<int> h = new HashSet<int>();
        h.Add(a);
        h.Add(b);
        h.Add(c);
        
        if (h.Count == 3)
            return a + b + c;
        
        if (h.Count == 2)
            return (a + b + c) * (a*a + b*b + c*c);
        
        if (h.Count == 1)
            return (a + b + c) * (a*a + b*b + c*c) * (a*a*a + b*b*b + c*c*c);
        
        return 1;
    }
}