using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {
        StringBuilder answer = new StringBuilder();
        
        // skip 문자들을 빠르게 확인하기 위해 HashSet 사용
        HashSet<char> skipSet = new HashSet<char>(skip);

        foreach (char c in s)
        {
            char current = c;
            int count = 0;

            while (count < index)
            {
                current++;

                // z를 넘어가면 다시 a로
                if (current > 'z')
                    current = 'a';

                // skip에 포함되지 않는 경우만 count 증가
                if (!skipSet.Contains(current))
                    count++;
            }

            answer.Append(current);
        }

        return answer.ToString();
    }
}
