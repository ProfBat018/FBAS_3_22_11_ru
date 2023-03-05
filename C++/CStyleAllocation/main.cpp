#include <iostream>

using namespace std;


int main() {
#pragma region Lesson1


#pragma region Part1
    /*
    int num = 5;
    int *number = &num;

    cout << "&num" << '\t' << &num << endl;
    cout << "number" << '\t' << number << endl;
    cout << "*number" << '\t' << *number << endl;
    */
#pragma endregion

    // malloc - memory allocation, то есть выделение памяти в heap
    // calloc - тоже самое что и malloc, но иницилизрует все


    // int arr[10];
#pragma region malloc

#pragma region OneValueAllocating

//    int *num = (int *) malloc(sizeof(int)); // * - создание указателя
//    *num = 5; // * - оператор разименовывания
//
//    cout
//            << "Address: " << num << '\n'
//            << "Value: " << *num << '\n';

//    *num = 10;
//    cout << *num;
#pragma endregion
#pragma region ArrayAllocating
/*
int length{};
cout << "Enter length: ";
cin >> length;
cout << endl;

int* arr = (int*)malloc(10 * sizeof(int));

    for (int i = 0; i < length; ++i) {
        *(arr + i) = i + 1; // arr[i] = i + 1
    }

    for (int i = 0; i < length; ++i) {
        cout << (arr + i) << '\t' << *(arr + i) << endl;
    }
*/
#pragma endregion


#pragma endregion


// int arr[10]{};
#pragma region Calloc

//int length{};
//cout << "Enter length: "; cin >> length;
//
//int* arr = (int*)calloc(length, length * sizeof(int));
//
//    for (int i = 0; i < length; ++i) {
//        cout << "Enter" << ' ' << i + 1 << ' ' << "element: ";
//        cin >> *(arr + i); // cin >> arr[i]
//    }
//
//    for (int i = 0; i < length; ++i) {
//        cout << (arr + i) << ' ' << *(arr + i) << endl;
//    }


#pragma endregion
#pragma endregion
#pragma region Lesson2

//    int *arr, *tmpArr;
//    int length{}, newLength{};
//
//    cout << "Enter length of your array: ";
//    cin >> length;
//
//    arr = (int *) calloc(length, length * sizeof(int)); // 10 elements in heap
//
//    for (int i = 0; i < length; ++i) {
//        *(arr + i) = i + 1;
//    }
//
//    cout << "Generated array is: ";
//    for (int i = 0; i < length; ++i) {
//        cout << *(arr + i) << ' ';
//    }
//    cout << endl;
//
//
//    cout << "Enter new length of your array: ";
//    cin >> newLength;
//
//    tmpArr = (int *) calloc(length, length * sizeof(int));
//
//    for (int i = 0; i < length; ++i) {
//        *(tmpArr + i) = *(arr + i);
//    }
//
//    free(arr);
//
//
//    arr = (int *) calloc(newLength, newLength * sizeof(int));
//
//    for (int i = 0; i < length; ++i) {
//        *(arr + i) = *(tmpArr + i);
//    }
//
//    free(tmpArr);
//
//    for (int i = 0; i < newLength; ++i) {
//        cout << *(arr + i) <<  ' ';
//    }
//    cout << endl;

#pragma endregion
#pragma region Part3
/*
    // Создаю int массив из 5 элементов в Heap
    int *arr1 = (int*) malloc(sizeof(int) * 5);

    // Создаю int массив из 5 элементов в Heap
    int *arr2 = (int*) calloc(5, sizeof(int) * 5);

    for (int i = 0; i < 5; ++i) {
        cout << arr1[i] << ' ';
    }

    cout << endl;

    for (int i = 0; i < 5; ++i) {
        cout << arr2[i] << ' ';
    }

    */
#pragma endregion
#pragma region WhyWeNeedFree
/*
int num = 5;

cout << "Before if" << endl;
if (num) {
    int* arr = (int*) calloc(5, sizeof(int) * 5);

    for (int i = 0; i < 5; ++i) {
        arr[i] = i + 1;
    }

    free(arr);
}

cout << "After if" << endl;

#pragma endregion

*/


    int *arr1 = new int[5]{}; // calloc
//int *arr2 = new int[5]; // malloc

    for (int i = 0; i < 5; ++i) {
        arr1[i] = i + 1;
    }

    cout << "Before deleting..." << endl;
    for (int i = 0; i < 5; ++i) {
        cout << arr1[i] << ' ';
    }

    delete[] arr1;


    cout << "After deleting..." << endl;
    for (int i = 0; i < 5; ++i) {
        cout << arr1[i] << ' ';
    }

#pragma endregion

    return 0;
}




