using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int H = park.Length;
        int W = park[0].Length;
        
        // 1. 시작 지점(S) 찾기
        int r = 0, c = 0;
        for (int i = 0; i < H; i++) {
            int startIdx = park[i].IndexOf('S');
            if (startIdx != -1) {
                r = i;
                c = startIdx;
                break;
            }
        }

        // 방향 벡터 설정 (N, S, W, E)
        Dictionary<string, (int dr, int dc)> dirMap = new Dictionary<string, (int, int)> {
            { "N", (-1, 0) },
            { "S", (1, 0) },
            { "W", (0, -1) },
            { "E", (0, 1) }
        };

        // 2. 명령 수행
        foreach (string route in routes) {
            string[] parts = route.Split(' ');
            string dir = parts[0];
            int dist = int.Parse(parts[1]);

            int dr = dirMap[dir].dr;
            int dc = dirMap[dir].dc;

            int nr = r;
            int nc = c;
            bool isPossible = true;

            // 한 칸씩 이동하며 검증
            for (int i = 0; i < dist; i++) {
                nr += dr;
                nc += dc;

                // 공원을 벗어나거나 장애물을 만나는지 체크
                if (nr < 0 || nr >= H || nc < 0 || nc >= W || park[nr][nc] == 'X') {
                    isPossible = false;
                    break;
                }
            }

            // 이동이 가능할 때만 실제 위치 갱신
            if (isPossible) {
                r = nr;
                c = nc;
            }
        }

        return new int[] { r, c };
    }
}