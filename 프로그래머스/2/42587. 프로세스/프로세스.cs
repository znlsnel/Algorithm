using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        
        // 1. (우선순위, 원래 위치)를 담은 큐 생성
        Queue<(int Priority, int Index)> queue = new Queue<(int Priority, int Index)>();
        for (int i = 0; i < priorities.Length; i++) {
            queue.Enqueue((priorities[i], i));
        }
        
        // 2. 우선순위 비교를 위해 내림차순으로 정렬된 리스트 준비 (또는 Max 값 활용)
        // 여기서는 매번 큐의 Max값을 체크하거나 정렬된 리스트를 활용할 수 있습니다.
        List<int> sortedPriorities = priorities.OrderByDescending(p => p).ToList();
        
        while (queue.Count > 0) {
            var current = queue.Dequeue();
            
            // 3. 현재 꺼낸 프로세스의 우선순위가 가장 높은지 확인
            if (current.Priority < sortedPriorities[answer]) {
                // 더 높은 게 있다면 다시 뒤로 넣기
                queue.Enqueue(current);
            } else {
                // 실행되는 경우
                answer++;
                
                // 4. 내가 찾는 프로세스인지 확인
                if (current.Index == location) {
                    return answer;
                }
            }
        }
        
        return answer;
    }
}