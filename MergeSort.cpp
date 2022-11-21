#include <iostream>
#include <vector>
using namespace std;

template <typename T>
vector<T> merge(vector<T>& arr1, vector<T>& arr2)
{
	vector<T> merged;

	auto iter1 = arr1.begin();
	auto iter2 = arr2.begin();

	while (iter1 != arr1.end() && iter2 != arr2.end())
	{
		if (*iter1 < *iter2)
		{
			merged.emplace_back(*iter1);
			++iter1;
		}
		else
		{
			merged.emplace_back(*iter2);
			++iter2;
		}
	}
	// iter1과 iter2의 길이가 다르다면 병합되지 않은
	//	데이터가 있을 수 있음
	if (iter1 != arr1.end())
	{
		for (; iter1 != arr1.end(); ++iter1)
			merged.emplace_back(*iter1);
	}
	else
	{
		for (;iter2 != arr2.end(); ++iter2)
			merged.emplace_back(*iter2);
	}
	return merged;
}

template <typename T>
vector<T> merge_sort(vector<T> arr)
{
	if (arr.size() > 1)
	{
		auto  mid = size_t(arr.size() / 2);
		auto left_half = merge_sort<T>(vector<T>(arr.begin(), arr.begin() + mid));
		auto right_half = merge_sort<T>(vector<T>(arr.begin() + mid, arr.end()));

		return merge<T>(left_half, right_half);
	}
	return arr;
}

template<typename T>
void print_vector(vector<T> arr)
{
	for (auto i : arr)
		cout << i << " ";
	cout << endl;
}

void run_merge_sort_test()
{
	vector<int> S1{ 2 , 5, 87, 2, 56, 32, 53, 7, 4, 2, 9, 4, 6 };
	vector<float> S2{ 24.0f , 2.7f, 9.12f, 12.0f, 12.1f, 12.3f, 12.2f , 7.2f, 42.1f, 24.2f, 9.0f};
	vector<double> S3{ 12.4,224.4, 2.4, 2.545, 23.87, 5.45, 452.99, 34.23, 1.1};
	vector<char> S4{ 'a', 'c', 'q', 'a', 'z', 'm', 'g', 'e', 'i' };

	print_vector<int>(S1);
	print_vector<float>(S2);
	print_vector<double>(S3);
	print_vector<char>(S4);
	cout << endl;

	auto sortS1 = merge_sort<int>(S1);
	auto sortS2 = merge_sort<float>(S2);
	auto sortS3 = merge_sort<double>(S3);
	auto sortS4 = merge_sort<char>(S4);

	print_vector<int>(sortS1);
	print_vector<float>(sortS2);
	print_vector < double > (sortS3);
	print_vector<char>(sortS4);

}

int main()
{

	run_merge_sort_test();
	return 0;
}
