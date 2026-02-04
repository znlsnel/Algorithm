public class Solution {
    public string solution(string s, int n) {
        string answer = "";

        foreach (char c in s)
        {
            // 공백은 그대로
            if (c == ' ')
            {
                answer += ' ';
                continue;
            }

            // 대문자 범위
            if (c >= 'A' && c <= 'Z')
            {
                answer += (char)((c - 'A' + n) % 26 + 'A');
            }
            // 소문자 범위
            else if (c >= 'a' && c <= 'z')
            {
                answer += (char)((c - 'a' + n) % 26 + 'a');
            }
        }

        return answer;
    }
}
