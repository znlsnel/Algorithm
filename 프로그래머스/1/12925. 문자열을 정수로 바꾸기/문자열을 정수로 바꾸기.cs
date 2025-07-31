public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        bool flag = false;
        
        if (s[0] == '-')
            flag = true;
        
        
        int idx = 0;
        while (idx < s.Length)
        {
            if (s[idx] >= '0' && s[idx] <= '9')
            {
                answer *= 10;
                answer += s[idx] - '0';
            }
            idx++;
        }
            
        return flag ? -answer : answer;
    }
}