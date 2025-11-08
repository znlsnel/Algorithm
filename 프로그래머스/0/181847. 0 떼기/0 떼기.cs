using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        if (n_str[0] == '0')
        {
            bool flag = false;
            for (int i = 1 ; i < n_str.Length; i++)
            {
                if (flag == false)
                {
                    if (n_str[i] != '0')
                        flag = true;
                    else
                        continue;
                }
                
                answer += n_str[i];
                
            }
            return answer;
        }
        else
            return n_str;
    }
}