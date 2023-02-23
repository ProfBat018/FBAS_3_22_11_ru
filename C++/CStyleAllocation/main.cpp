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


int length{};
cout << "Enter length: ";
cin >> length;

int* arr = new int[length]{};

    return 0;
}
