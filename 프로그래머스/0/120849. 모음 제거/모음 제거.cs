using System;
using System.Text;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string my_string) 
    {
        HashSet<char> h = new HashSet<char>()
        {
          'a', 'e', 'i', 'o', 'u'  
        };
        StringBuilder sb = new StringBuilder();
        
        foreach (char c in my_string)
        {
            if (!h.Contains(c))
                sb.Append(c);
        }
        
        return sb.ToString();
    }
}