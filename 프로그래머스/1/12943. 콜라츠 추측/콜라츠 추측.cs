public class Solution {
    public int solution(int num) {
        long n = num;   // 연산 중 값이 커질 수 있어 long으로 처리
        int count = 0;

        if (n == 1)
            return 0;

        while (n != 1) {
            if (count >= 500)
                return -1;

            if (n % 2 == 0)
                n /= 2;
            else
                n = n * 3 + 1;

            count++;
        }

        return count;
    }
}
