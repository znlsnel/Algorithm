#include <iostream>

using namespace std;

// Union-Find

int getParent(int parent[], int n)
{
	if (parent[n] == n) return n;
	return parent[n] = getParent(parent, parent[n]);
}

void unionParent(int parent[], int a, int b)
{
	a = getParent(parent, a);
	b = getParent(parent, b);
	if (a < b) parent[b] = a;
	else parent[a] = b;
}

bool findParent(int parent[], int a, int b)
{
	if (getParent(parent, a) == getParent(parent, b))
		return true;
	return false;
}

int main()
{
	int parent[10] = { 0 };
	for (int i = 0; i < 10; i++)
		parent[i] = i;

	unionParent(parent, 1, 2);
	unionParent(parent, 2, 3);
	unionParent(parent, 3, 4);
	unionParent(parent, 5, 6);
	unionParent(parent, 6, 7);
	unionParent(parent, 7, 8);
	unionParent(parent, 8, 9);

	cout << findParent(parent, 8, 4) << endl;
	unionParent(parent, 3, 5);
	cout << findParent(parent, 8, 4) << endl;


	return 0;

}
