using System;

public class Solution 
{
    public int[] solution(int brown, int yellow) 
    {
        int[] answer = new int[2];
        
        // 간단한 알고리즘 * 넌센스
        
        int size = brown + yellow;
        
        // size를 만들 수 있는 곱셈 연산 찾기
        // 해당 연산 중에서 brown, yellow와 개수가 맞는 애들 찾기
        
        for (int h = 3; h < size; h++)
        {
            int w = size / h;

            if (size % w > 0 || h * w != size)
                continue;

            int ywSize = (h - 2) * (w - 2);

            if (ywSize == yellow)
            {
                answer[0] = w;
                answer[1] = h;
                return answer;
            }
        }
        
        
        // width -> 4
        // height -> 3
        
        // Yellow Width => width - 2;
        // Yellow Height => height - 2;
        // Yellow Size = (width - 2) * (height - 2)
        
        
        return answer;
    }
}