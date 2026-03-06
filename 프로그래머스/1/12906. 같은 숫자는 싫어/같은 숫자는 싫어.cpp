#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> arr) 
{
    vector<int> answer;

    for (int i = 0; i < arr.size(); i++) {
        // 1. answer가 비어있거나, 
        // 2. 마지막에 넣은 숫자와 현재 숫자가 다를 경우에만 push_back
        if (answer.empty() || answer.back() != arr[i]) {
            answer.push_back(arr[i]);
        }
    }

    return answer;
}