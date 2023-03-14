#include <iostream>

using namespace std;



int main() {

    // int number{}; // обычная переменная.

    int number{10}; // number = 10
    int *ptrNumber{}; // 000000
    cout << "Value of pointer: " << ptrNumber << endl;

    ptrNumber = &number;

    int **ptrToPtrNumber = &ptrNumber;
    cout
            << "Address of &number: \t\t" << &number << '\t' << "Value of number:\t" << number << '\n'
            << "Adress of ptrNumber: \t\t" << &ptrNumber << '\t' << "Value of ptrNumber:\t" << ptrNumber << '\n'
            << "Address of &ptrToPtrNumber: \t" << &ptrToPtrNumber << '\t' << "Value of ptrToPtrNumber:\t" << ptrToPtrNumber << '\n'
            << "Address of &(*ptrToPtrNumber): \t" << &(*ptrToPtrNumber) << '\t' << "Value of *ptrToPtrNumber:\t" << *ptrToPtrNumber << '\n'
            << "Address of: &(**ptrToPtrNumber)\t" << &(**ptrToPtrNumber) << '\t' << "Value of **ptrToPtrNumber:\t" << **ptrToPtrNumber << '\n';
    return 0;
}

#pragma region DynamicMultiArrays

//int main() {

//    int arr[10]{}; // Статический массив
//    int* arr = new int[10]{}; // Динамический массив

//    int arr[10]{}; // Статический одномерный массив
//    int arr[2][2]{}; // Статический многомерный массив

// Статический многомерный
//    int arr[2][2]{
//            {1, 2},
//            {3, 4}
//    };
//
//    for (int i = 0; i < 4; ++i) {
//        cout << arr[0][i] << ' ';
//    }


// Зубчатый массив - Jagged array

//int **arr = new int*[2]{};
//arr[0] = new int[2]{1, 2};
//arr[1] = new int[3]{3, 4, 5};
//
//
//    for (int i = 0; i < 2; ++i) {
//        for (int j = 0; j < 2; ++j) {
//            cout << (*(arr + i) + j) << ' ';
//        }
//        cout << endl;
//    }
//
//    for (int i = 0; i < 2; ++i) {
//        for (int j = 0; j < 2; ++j) {
//            cout << *(*(arr + i) + j) << ' ';
//        }
//        cout << endl;
//    }

//    const int row = 2;
//    const int col = 2;
//
//    int **arr = new int*[row]{};
//    arr[0] = new int[col]{1, 2};
//    arr[1] = new int[col]{3, 4};

//    for (int i = 0; i < row; ++i) {
//        arr[i] = new int[col]{};
//    }

//    return 0;
//}

#pragma endregion
