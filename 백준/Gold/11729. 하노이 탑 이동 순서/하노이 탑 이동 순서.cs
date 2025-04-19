 

public static class PS
{
    private static readonly StreamWriter sw;

    static PS()
    {
        sw = new(new BufferedStream(Console.OpenStandardOutput()));
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        sw.WriteLine(Math.Pow(2, n) - 1);
        Hanoi(n, 1, 2, 3);
        sw.Close();
    }

    private static void Hanoi(int n, int from, int via, int to)
    {
        if (n == 0)
            return;

        Hanoi(n - 1, from, to, via);

        sw.Write(from);
        sw.Write(' ');
        sw.WriteLine(to);

        Hanoi(n - 1, via, from, to);
    }
}