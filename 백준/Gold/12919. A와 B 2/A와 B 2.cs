using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


public class Solution
{

	string S, T;
	bool found = false;

	private void DFS(string current)
	{
		if (found) return;

		if (current.Length == S.Length)
		{
			if (current == S)
				found = true;
			return;
		}

		if (current.Length <= S.Length) return;

		// 1. 끝이 A면 A 제거하고 계속
		if (current[current.Length - 1] == 'A')
		{
			DFS(current.Substring(0, current.Length - 1));
		}

		// 2. 시작이 B가 아니라 → 뒤집었을 때 끝이 B인 경우
		// 즉, 뒤집고 나서 B 제거
		if (current[0] == 'B')
		{
			char[] arr = current.ToCharArray();
			Array.Reverse(arr);
			string reversed = new string(arr);

			if (reversed[reversed.Length - 1] == 'B')
			{
				DFS(reversed.Substring(0, reversed.Length - 1));
			}
		}
	}

	public int solution(string s, string t)
	{
		S = s;
		T = t;
		DFS(t);

		return found ? 1 : 0;
	}
}





class Program
{
	static void Main(string[] args)
	{
		string S = Console.ReadLine();
		string T = Console.ReadLine();

		Solution solution = new Solution();
		Console.WriteLine(solution.solution(S, T));
	}
}

// A를 추가
// B를 추가 후 뒤집기

// S로 T를 만들 수 있는지 체크
// 문자열 길이로 체크하기



