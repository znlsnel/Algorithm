using System;

public class Solution 
{
    private int[,] board;
    
    private int N;
    private int[] dy = {0, 1, 0, -1};
    private int[] dx = {1, 0, -1, 0};
    private int num = 1;
    private int visitedCnt = 1;
    
    public void Move(int dir, int y, int x)
    {
       // Console.WriteLine($"Dir : {dir} ,  YX : {y}, {x}");
        if (visitedCnt >= N * N)
            return;
        
        while (true)
        {
            int ny = y + dy[dir];
            int nx = x + dx[dir];
            
            if (ny < 0 || ny >= N || nx < 0 || nx >= N || board[ny, nx] != 0)
                break;
            
            y = ny;
            x = nx;
            board[y, x] = ++num;
            visitedCnt++;
        }
        
        
        Move((dir + 1)%4, y, x);
    }
    
    public int[,] solution(int n) 
    {
        N = n;
        board = new int[n, n];

        board[0, 0] = 1;
        
        Move(0, 0, 0);
        
        return board;
    }
}

// [1, 2, 3, 4]
// [12, 13, 14, 5]
// [11, 16, 15, 6]
// [10, 9, 8, 7]