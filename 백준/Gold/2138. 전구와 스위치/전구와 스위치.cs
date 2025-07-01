using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{
	StringBuilder l;
	StringBuilder t;

	int MAX = 99999999;
	int N, cnt, ans = 99999999;

	void ClickSwitch(int idx)
	{
		if (idx >= 1) 
			l[idx - 1] = l[idx - 1] == '0' ? '1' : '0';

		l[idx] = l[idx] == '0' ? '1' : '0';

		if (idx < N-1) 
			l[idx+1] = l[idx + 1] == '0' ? '1' : '0';

	}

	void solve(StringBuilder lights, int start)
	{
		l = new StringBuilder(lights.ToString());
		cnt = 0;
		if (start == 0)
		{
			l[0] = l[0] == '0' ? '1' : '0';
			l[1] = l[1] == '0' ? '1' : '0';
			cnt++;
		}
		
		for (int i = 1; i < N; i++)
		{
			if (l[i-1] != t[i-1])
			{
				ClickSwitch(i);
				cnt++;
			}
		}
		if (l.ToString() == t.ToString())
			ans = Math.Min(ans, cnt);
	}

	public int solution(int n, StringBuilder lights, StringBuilder target)
	{
		N = n;
		t = target;
		solve(lights, 0);
		solve(lights, 1);

		if (ans != MAX)
			return ans;
		else 
			return -1;
	}
}


class Program
{
	static void Main(string[] args)
	{
		Solution solution = new Solution();

		int N = int.Parse(Console.ReadLine());
		StringBuilder lights = new StringBuilder(Console.ReadLine());
		StringBuilder target = new StringBuilder(Console.ReadLine());

		Console.WriteLine(solution.solution(N, lights, target));
	}
}

