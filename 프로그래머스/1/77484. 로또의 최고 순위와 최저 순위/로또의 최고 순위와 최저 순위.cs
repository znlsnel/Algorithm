using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        // 1. 맞은 번호 개수 구하기
        int matchCount = lottos.Intersect(win_nums).Count();
        
        // 2. 알아볼 수 없는 번호(0) 개수 구하기
        int zeroCount = lottos.Count(x => x == 0);

        // 3. 최고/최저 당첨 개수 계산
        int maxMatch = matchCount + zeroCount;
        int minMatch = matchCount;

        // 4. 개수를 순위로 변환하는 로직 (배열 활용)
        // index 0: 0개 맞음, index 6: 6개 맞음
        int[] rankMap = { 6, 6, 5, 4, 3, 2, 1 };

        return new int[] { rankMap[maxMatch], rankMap[minMatch] };
    }
}