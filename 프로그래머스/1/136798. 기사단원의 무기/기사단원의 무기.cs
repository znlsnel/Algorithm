using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;

        for (int i = 1; i <= number; i++)
        {
            int count = 0;
            int sqrt = (int)Math.Sqrt(i);

            for (int j = 1; j <= sqrt; j++)
            {
                if (i % j == 0)
                {
                    count += 2; // j와 i/j 두 개의 약수
                }
            }

            // 만약 i가 완전제곱수라면 sqrt가 중복으로 세어졌으므로 하나 빼기
            if (sqrt * sqrt == i)
                count--;

            // 제한 초과 시 power로 대체
            if (count > limit)
                count = power;

            answer += count;
        }

        return answer;
    }
}
