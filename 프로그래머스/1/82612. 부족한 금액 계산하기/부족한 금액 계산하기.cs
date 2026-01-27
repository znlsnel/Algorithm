using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long total = (long)price * count * (count + 1) / 2;
        long shortage = total - money;
        return shortage > 0 ? shortage : 0;
    }
}
