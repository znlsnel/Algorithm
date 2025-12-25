using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int[] indices) {
        HashSet<int> removeSet = new HashSet<int>(indices);
        string result = "";

        for (int i = 0; i < my_string.Length; i++) {
            if (!removeSet.Contains(i)) {
                result += my_string[i];
            }
        }

        return result;
    }
}
