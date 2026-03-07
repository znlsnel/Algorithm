#include <iostream>
#include <string>
#include <vector>

using namespace std;

int solution(string s)
{
    // 문자를 담을 스택 역할을 할 벡터
    vector<char> stack;

    for (char c : s) {
        // 스택이 비어있지 않고, 맨 위의 문자가 현재 문자와 같다면
        if (!stack.empty() && stack.back() == c) {
            stack.pop_back(); // 짝이 맞으므로 제거
        } 
        else {
            stack.push_back(c); // 짝이 아니면 스택에 추가
        }
    }

    // 스택이 완전히 비어있으면 1, 아니면 0 리턴
    return stack.empty() ? 1 : 0;
}