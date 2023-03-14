#include <iostream>
using namespace std;

int main()
{
	/*
	 Массив, это по умолчанию указатель
	 Массив хранит в себе адрес первого элемента.
	*/

	/*
	int arr[]{ 1, 2, 3, 4, 5 };

	cout << arr << endl;

	for (size_t i = 0; i < 5; i++)
	{
		cout << arr[i] << ' ';
	}
	cout << endl;

	for (size_t i = 0; i < 5; i++)
	{
		cout << arr + i << '\t' <<  *(arr + i) << endl;
	}
	*/

	// Нельзя создавать массив без длины.
	// Длина статического массива должна быть константной

	//const int length = 5;
	//int arr[length];
	//// или
	//int arr2[5];
	//// или
	//int arr3[]{ 1, 2, 3 };

	const int length = 5;
	int nums[length];

	for (size_t i = 0; i < length; i++)
	{
		cout << "Enter num: ";
		cin >> nums[i];
	}

	for (size_t i = 0; i < length; i++)
	{
		cout << nums[i] << ' ';
	}

	return 0;
}
