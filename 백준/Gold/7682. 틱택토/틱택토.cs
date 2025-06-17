using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
	static private readonly string VALID = "valid";
	static private readonly string INVALID = "invalid";
	private (int, int) GetWinCnt(List<string> board)
	{
		(int, int) ret = (0, 0);
		int x = 0; int o = 0;
		for (int i = 0; i < 3; i++)
		{
			if (board[i][0] == board[i][1] && board[i][1] == board[i][2])
			{
				if (board[i][0] == 'X')
					x++;
				else if (board[i][0] == 'O')
					o++;
			}

			if (board[0][i] == board[1][i] && board[1][i] == board[2][i])
			{
				if (board[0][i] == 'X')
					x++;
				else if (board[0][i] == 'O')
					o++;
			}

		}

		if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
		{
			if (board[1][1] == 'X')
				x++;
			else if (board[1][1] == 'O')
				o++;
		}

		if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
		{
			if (board[1][1] == 'X')
				x++;
			else if (board[1][1] == 'O') 
				o++;
		}

		ret = (ret.Item1 + x, ret.Item2 + o);

		return ret;
	}

	public string solution(string board)
	{
		int xCnt = 0;
		int oCnt = 0;
		int eCnt = 0;

		foreach (char c in board)
		{
			if (c == 'X')
				xCnt++;
			else if (c == 'O')
				oCnt++;
			else
				eCnt++;
		}

		var (xWin, oWin) = GetWinCnt(new List<string>() { board.Substring(0, 3), board.Substring(3, 3), board.Substring(6, 3)});
		if ( xWin > 0 && oWin > 0)
			return INVALID;

		if (xWin + oWin == 0 && eCnt > 0)
			return INVALID;

		if (xWin == 1 && xCnt == oCnt) 
			return INVALID;

		if (oWin == 1 && xCnt != oCnt)
			return INVALID;

		if (oCnt > xCnt)
			return INVALID;

		if (xCnt > oCnt+1)
			return INVALID;
		 
		return VALID;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		while (true)
		{
			string input = Console.ReadLine();
			if (input == "end")
				break;

			Console.WriteLine(solution.solution(input));
		}
	}
}

