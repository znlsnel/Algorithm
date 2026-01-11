using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        Queue<int> bridge = new Queue<int>();
        int time = 0;
        int currentWeight = 0;
        int idx = 0;

        // 다리 길이만큼 0으로 채워서 시작
        for (int i = 0; i < bridge_length; i++)
            bridge.Enqueue(0);

        while (idx < truck_weights.Length) {
            time++;

            // 다리에서 한 칸 이동 (맨 앞 트럭 빠짐)
            currentWeight -= bridge.Dequeue();

            // 다음 트럭을 올릴 수 있는지 확인
            if (currentWeight + truck_weights[idx] <= weight) {
                bridge.Enqueue(truck_weights[idx]);
                currentWeight += truck_weights[idx];
                idx++;
            } else {
                // 못 올리면 0을 넣어서 시간만 흐르게 함
                bridge.Enqueue(0);
            }
        }

        // 마지막 트럭이 다리를 완전히 건너는 시간 추가
        time += bridge_length;

        return time;
    }
}
