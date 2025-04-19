using System;
using System.Linq;

class 크로아티아_알파벳
{
    static string[] alpabet = new string[8]
    {
        "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="
    };

    static void Main()
    {
        string str = Console.ReadLine();
        Console.WriteLine(Count(str, alpabet));
    }

    static int Count(string str, string[] alpabet)
    {
        int answer = 0;
        int sum = 0;

        for (int i = 0; i < alpabet.Length; i++)
        {
            // 처음길이에서 - 타겟단어 전부 삭제 => 없어진 길이 획득 -> 이걸 단어 길이로 나누면 횟수 획득.
            sum = str.Length - str.Replace(alpabet[i], "").Length;
            str = str.Replace(alpabet[i], "_");
            answer += sum / alpabet[i].Length;
        }
        str = str.Replace("_", "");
        answer += str.Length;
        return answer;
    }
}