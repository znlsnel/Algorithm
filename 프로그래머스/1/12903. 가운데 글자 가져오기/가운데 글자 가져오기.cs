public class Solution {
    public string solution(string s) {
        int len = s.Length;
        int mid = len / 2;

        if (len % 2 == 1)
            return s.Substring(mid, 1);      // 홀수 → 가운데 1글자
        else
            return s.Substring(mid - 1, 2);  // 짝수 → 가운데 2글자
    }
}
