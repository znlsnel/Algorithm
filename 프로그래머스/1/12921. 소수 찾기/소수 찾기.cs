public class Solution {
    public int solution(int n) {
        bool[] isPrime = new bool[n + 1];

        // 처음엔 모두 소수(true)라고 가정
        for (int i = 2; i <= n; i++)
            isPrime[i] = true;

        // 에라토스테네스의 체
        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // 소수 개수 세기
        int count = 0;
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i]) count++;
        }

        return count;
    }
}
