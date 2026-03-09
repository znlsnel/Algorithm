#include <string>
#include <vector>
#include <algorithm>

using namespace std;

// 음식 번호(원래 인덱스) 기준으로 오름차순 정렬하기 위한 비교 함수
bool compareByIndex(pair<int, int> a, pair<int, int> b) {
    return a.second < b.second;
}

int solution(vector<int> food_times, long long k) {
    long long total_time = 0;
    for (int t : food_times) {
        total_time += t;
    }

    // 전체 음식을 먹는 시간보다 k가 크거나 같다면 더 이상 먹을 음식이 없으므로 -1 반환
    if (total_time <= k) return -1;

    // (음식 먹는 데 걸리는 시간, 음식 번호) 형태로 저장
    vector<pair<int, int>> foods;
    for (int i = 0; i < food_times.size(); ++i) {
        foods.push_back({food_times[i], i + 1});
    }

    // 시간이 적게 걸리는 음식부터 처리하기 위해 시간 기준 오름차순 정렬
    sort(foods.begin(), foods.end());

    long long previous_time = 0;   // 이전에 다 먹은 음식의 누적 시간
    long long length = food_times.size(); // 남은 음식의 개수

    int i = 0;
    for (; i < foods.size(); ++i) {
        // 현재 음식을 다 먹기 위해 추가로 필요한 시간
        long long diff = foods[i].first - previous_time;

        if (diff > 0) {
            long long spend = diff * length; // 이번 사이클에서 소모될 총 시간

            if (spend <= k) {
                // k가 충분하다면 한 번에 시간을 차감
                k -= spend;
                previous_time = foods[i].first;
            } else {
                // 남은 시간(k)이 부족해서 현재 음식을 다 먹지 못한다면 반복문 종료
                break;
            }
        }
        // 처리된 음식은 큐에서 제거되는 것과 동일하므로 남은 음식 개수 감소
        length--; 
    }

    // 다 먹지 못하고 남은 음식들을 원래 번호(인덱스) 순서대로 다시 정렬
    vector<pair<int, int>> result(foods.begin() + i, foods.end());
    sort(result.begin(), result.end(), compareByIndex);

    // 남은 시간(k)을 남은 음식 개수로 나눈 나머지 위치의 음식이 정답
    return result[k % length].second;
}