#include <iostream>

using namespace std;


int main() {
//    int arr[10]{}; // Статичный массив на 10 элементов
//    int* arr = new int[10]{}; // Динамичный массив на 10 элементов
// int arr[2][2]{}; // Статичный многомерный массив.
// int** arr = new int*[2]{}; // Динамичный многомерный массив, но все не так просто.


// На самом деле обычный одномерный массив...
//int arr[2][2]
//{
//    {1, 2},
//    {3, 4}
//};

// cout << arr[0][3];

    srand(time(NULL));

// Зубчатый массив или Jagged array
#pragma region Part

    // Создаю массив из указателей на указатели

//    int **arr = new int* [3]{};
//
//    arr[0] = new int[3]{};
//    arr[1] = new int[3]{};
//    arr[2] = new int[3]{};
//
//
//    for (int i = 0; i < 3; ++i) {
//        for (int j = 0; j < 3; ++j) {
//            *(*(arr + i) + j) = rand() % 10; // arr[i][j] = rand() % 10;
//        }
//    }
//
//    for (int i = 0; i < 3; ++i) {
//        for (int j = 0; j < 3; ++j) {
//            cout << *(*(arr + i) + j) << ' ';
//        }
//        cout << endl;
//    }
//
//    for (int i = 0; i < 3; ++i) {
//        for (int j = 0; j < 3; ++j) {
//            cout << *(arr + i) + j << ' ';
//        }
//        cout << endl;
//    }
//
#pragma endregion


#pragma region Part

//    int arr[2][3]{
//            {1, 2, 3},
//            {3, 4, 5}
//    };


int row = 3;
const int col = 3;

int** arr = new int*[row]{};

    for (int i = 0; i < row; ++i) {
        arr[i] = new int[col]{};
    }


#pragma endregion

    return 0;
}
