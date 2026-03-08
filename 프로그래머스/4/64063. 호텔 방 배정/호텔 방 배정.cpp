#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

// 방의 배정 상태와 다음 빈 방 번호를 저장할 해시 맵
unordered_map<long long, long long> room_map;

// 빈 방을 찾고, 경로를 압축하는 재귀 함수 (Union-Find의 Find 연산)
long long find_empty_room(long long n) {
    // 1. 원하는 방이 맵에 없다면 (비어있는 방이라면)
    if (room_map.find(n) == room_map.end()) {
        room_map[n] = n + 1; // 다음 빈 방은 n + 1 이라고 기록
        return n;            // 현재 방 n을 배정
    }
    
    // 2. 이미 배정된 방이라면, 다음 빈 방을 재귀적으로 탐색
    // 찾은 빈 방의 다음 번호로 현재 노드의 부모를 갱신 (경로 압축)
    return room_map[n] = find_empty_room(room_map[n]);
}

vector<long long> solution(long long k, vector<long long> room_number) {
    vector<long long> answer;
    
    // 고객들이 원하는 방 번호를 순서대로 순회
    for (long long num : room_number) {
        answer.push_back(find_empty_room(num));
    }
    
    return answer;
}