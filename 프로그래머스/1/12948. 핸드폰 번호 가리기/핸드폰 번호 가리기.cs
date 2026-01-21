public class Solution {
    public string solution(string phone_number) {
        int len = phone_number.Length;
        string hidden = new string('*', len - 4);
        string last4 = phone_number.Substring(len - 4);

        return hidden + last4;
    }
}
