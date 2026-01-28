public class Solution {
    public bool solution(string s) {
        // 길이가 4 또는 6이 아니면 false
        if (s.Length != 4 && s.Length != 6)
            return false;

        // 모든 문자가 숫자인지 확인
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
                return false;
        }

        return true;
    }
}
