public class Solution {
    public int solution(int a, int d, bool[] included) {
        int answer = 0;

        for (int i = 0; i < included.Length; i++) {
            int term = a + d * i;   // i번째 항 (1항은 i=0)
            if (included[i]) {
                answer += term;
            }
        }

        return answer;
    }
}
