#include <iostream>

using namespace std;

int n, k, state, zeroCnt;
int a[205];
bool robot[105];

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> n >> k;

    for (int i = 1; i <= 2 * n; i++)
    {
        cin >> a[i];
    }

    while (zeroCnt < k)
    {
        state++;

        for (int i = 2 * n; i >= 1; i--)
        {
            a[i + 1] = a[i];
            if (i < n)
                robot[i + 1] = robot[i];
        }
        a[1] = a[2 * n + 1];
        robot[1] = 0;
        robot[n] = 0;

        for (int i = n - 1; i > 0; i--)
        {
            if (robot[i] && !robot[i + 1] && a[i + 1] > 0)
            {
                robot[i + 1] = 1;
                robot[i] = 0;
                a[i + 1]--;
                if (a[i + 1] == 0)
                    zeroCnt++;
            }
        }
        robot[n] = 0;

        if (a[1] > 0)
        {
            robot[1] = 1;
            a[1]--;
            if (a[1] == 0)
                zeroCnt++;
        }
    }

    cout << state;

    return 0;
}