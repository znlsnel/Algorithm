public class Solution {
    public string solution(string s) {
        string answer = "";
        int idx = 0;

        foreach (char c in s) {
            if (c == ' ') {
                answer += c;
                idx = 0; // 단어가 끊기면 인덱스 초기화
            } else {
                answer += (idx % 2 == 0) ? char.ToUpper(c) : char.ToLower(c);
                idx++;
            }
        }

        return answer;
    }
}
