#include <iostream>

using namespace std;

int main()
{
	// Multidimensional arrays - многомерные массивы

	/*
		Многомерный массив - это массив, 
		где длина подмассивов должна быть одинаковой
	*/
	
#pragma region Part1

	/*
	int arr[3][5] =
	{
		{1, 3, 5},
		{2, 4, 6},
	};
	
	for (size_t i = 0; i < 3; i++)
	{
		for (size_t j = 0; j < 5; j++)
		{
			cout << arr[i][j] << ' ';
		}
		cout << endl;
	}
	*/
#pragma endregion

#pragma region Part2

	//int arr[][2]{ 1, 2, 3, 4 };

	//for (size_t i = 0; i < 2; i++)
	//{
	//	for (size_t j = 0; j < 2; j++)
	//	{
	//		cout << arr[i][j] << ' ';
	//	}
	//	cout << endl;
	//}

	

	//int arr[][2] = { {1, 2}, {3, 4} }; // На самом деле он одномерный )) 

	//cout << arr[0] << endl;
	//cout << &arr[0][1] << endl;
	//cout << arr[1] << endl;
	//cout << &arr[1][1] << endl;


#pragma endregion


#pragma region ChessExample


	int arr[8][8]{};

	// 0 - black
	// 1 - white

	for (size_t i = 0; i < 8; i++)
	{
		for (size_t j = 0; j < 8; j++)
		{
			if (i % 2 == 0 && j % 2 == 0)
			{
				arr[i][j] = 0;
			}
			else if (i % 2 == 0 && j % 2 != 0)
			{
				arr[i][j] = 1;
			}
			else if (i % 2 != 0 && j % 2 == 0)
			{
				arr[i][j] = 1;
			}
			else if (i % 2 != 0 && j % 2 != 0)
			{
				arr[i][j] = 0;
			}
		}
	}

	int rows = 8;
	for (size_t i = 0; i < 8; i++, rows--)
	{
		cout << rows << "  ";
		for (size_t j = 0; j < 8; j++)
		{
			cout << '|' << arr[i][j];
		}
		cout << endl;
	}

	cout << "   ";
	for (size_t columns = 97; columns <= 104; columns++)
	{
		cout << ' ' << (char)columns;
	}


#pragma endregion


	return 0;
}
