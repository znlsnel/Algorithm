public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        foreach (int n in arr)
            answer += n;
        answer /= arr.Length;
        return answer;
    }
}