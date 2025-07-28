public class Solution {
    public bool solution(int x) {
        bool answer = true;
        
        int tempX = x;
        int num = 0;
        
        while (tempX > 0)
        {
            num += tempX % 10;
            tempX /= 10;
        }
        
        return x % num == 0;
    }
}