#include <iostream>

using namespace std;

int main()
{
	int arr[10]{ 5,7,6,2,3,1,9,8,4,24 };

	for (int i = 0; i <= 9; i++)
	{
		int c = i;
		int root = 0;
		do
		{
			root = (c - 1) / 2;
			if (arr[c] > arr[root])
			{
				int temp = arr[c];
				arr[c] = arr[root];
				arr[root] = temp;
			}
			c = root;
		}while(root != 0);
	}

	for (int i = 9; i >= 0 ; i--)
	{
		int temp = arr[0];
		arr[0] = arr[i];
		arr[i] = temp;

		int root = 0;
		int c = 0;
		do 
		{
			c = 2 * root + 1;
			
			if (c < i - 1 && arr[c] < arr[c + 1])
				c++;
			
			if (c < i && arr[c] > arr[root])
			{
				temp = arr[root];
				arr[root] = arr[c];
				arr[c] = temp;
			}
			root = c;

		} while (c < i);
	}

	for (int i = 0; i < 10; i++)
		cout << arr[i] << " - ";
	return 0;
}
