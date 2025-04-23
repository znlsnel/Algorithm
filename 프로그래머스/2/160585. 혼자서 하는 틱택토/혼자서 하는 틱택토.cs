using System;

public class Solution 
{
    // 3 x 3 문제의 공식
    public bool Find(string[] board, char c)
    {
        
        for (int i = 0; i < 3; i++)
        {
            if (board[i][0] == c && board[i][0] == board[i][1] && board[i][1] == board[i][2])
                return true;
            
            if (board[0][i] == c && board[0][i] == board[1][i] && board[1][i] == board[2][i])
                return true;
        }
        
        if (board[0][0] == c && board[0][0] == board[1][1] && board[1][1] == board[2][2])
            return true;
        
        if (board[0][2] == c && board[0][2] == board[1][1] && board[1][1] == board[2][0])
            return true;
        
        return false;
    }
    
    public int solution(string[] board) 
    {
        int answer = -1;
        
        int xCnt = 0;
        int oCnt = 0;
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                xCnt += board[i][j] == 'X' ? 1 : 0;
                oCnt += board[i][j] == 'O' ? 1 : 0; 
            }
        }
        
        bool xSuccess = Find(board, 'X');
        bool oSuccess = Find(board, 'O');
        
        Console.WriteLine($"{xCnt} {oCnt} {xSuccess} {oSuccess}");
        
        if (xSuccess && oSuccess)
            return 0;
        
        if (xCnt > oCnt || oCnt > xCnt+1)
            return 0;

        if (xSuccess && xCnt < oCnt)
            return 0;

        if (oSuccess && xCnt == oCnt)
            return 0;
        
        return 1;
    }
}

// 1. X의 수 
// 2. O의 수
// 3. 승리 조건의 수

// 조건
// 1. 가로, 세로, 대각선 한줄 체우면 승리~
// 2. 꽉 채워서 놓을 곳이 없으면 무승부~

// 가능 한 조건
// 1. 승리 조건이 1개면서, 두 표시의 차이가 0개 이하일 때
// 2. 승리 조건이 없으면서, 두 표시의 차이가 같을 때

// OOX
// XXO  1
// OXX

// OOX
// XXO  1
// OOX

// OOX
// XXO  1
// O.X


// 0.X
// .O.  1
// ..X

// OOO
// ...  0
// XXX

// ...
// .X.  0
// ...

// ...
// ...  1
// ...

