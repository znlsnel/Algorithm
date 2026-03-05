#include <string>
#include <iostream>
#include <cctype> // tolower 함수를 사용하기 위해 필요

using namespace std;

bool solution(string s)
{
    int p_count = 0;
    int y_count = 0;

    // 문자열의 각 문자를 확인하는 범위 기반 for 루프
    for (char c : s) {
        // 소문자로 변환하여 비교 (대소문자 구분 X)
        char lower_c = tolower(c);
        
        if (lower_c == 'p') {
            p_count++;
        } else if (lower_c == 'y') {
            y_count++;
        }
    }

    // 두 개수가 같으면 true, 다르면 false 반환
    return p_count == y_count;
}