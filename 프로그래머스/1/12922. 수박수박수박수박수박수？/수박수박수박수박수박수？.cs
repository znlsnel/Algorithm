public class Solution {
    public string solution(int n) {
        var sb = new System.Text.StringBuilder();

        for (int i = 0; i < n; i++) {
            sb.Append(i % 2 == 0 ? "수" : "박");
        }

        return sb.ToString();
    }
}
