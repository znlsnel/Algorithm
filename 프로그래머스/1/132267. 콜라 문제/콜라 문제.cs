public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;

        while (n >= a) {
            int newCola = (n / a) * b;
            answer += newCola;
            n = (n % a) + newCola;
        }

        return answer;
    }
}
