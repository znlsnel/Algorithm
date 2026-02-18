using System;

public class Solution {
    public int solution(string[] babbling) {
        string[] words = { "aya", "ye", "woo", "ma" };
        int answer = 0;

        foreach (string b in babbling)
        {
            string temp = b;
            string last = ""; // 직전에 사용한 발음
            bool valid = true;

            while (temp.Length > 0)
            {
                bool matched = false;

                foreach (string w in words)
                {
                    if (temp.StartsWith(w))
                    {
                        // 같은 발음이 연속되면 불가능
                        if (last == w)
                        {
                            valid = false;
                            break;
                        }

                        last = w;
                        temp = temp.Substring(w.Length);
                        matched = true;
                        break;
                    }
                }

                if (!matched)
                {
                    valid = false;
                    break;
                }
            }

            if (valid) answer++;
        }

        return answer;
    }
}
