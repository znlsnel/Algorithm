using System;


class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        while (n > 0)
        {
            if (n % 2 == 1)
                ++answer;
            n /= 2;
        }
        
        return answer;
    }
}


// K 칸 이동 (비용 K)
// 혹은 
// 현재 위치 X 2에 해당하는 위치로 순간이동 (비용 0) 

// 