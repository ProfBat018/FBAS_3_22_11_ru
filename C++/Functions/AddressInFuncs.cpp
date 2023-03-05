#include <iostream>

using namespace std;

#pragma region RegularParam

//void change(int number)
//{
//    number = 10;
//}
//
//
//int main()
//{
//    int num;
//    cout << "Enter number: " << endl;
//    cin >> num; // 5
//
//    change(num);
//    cout << num << endl;
//
//    return 0;
//}


#pragma endregion
#pragma region AddressParam

/*
void change(int &number)
{
    number = 10;
}


int main()
{
    int num{};
    cout << "Enter number: ";
    cin >> num; // 4

    change(num);
    cout << num << endl;

    return 0;
}
 */


#pragma endregion

#pragma region ArrayToParam

#pragma region Highlevelmethod
/*
void initializeArray(int arr[], const int length)
{
    for (int i = 0; i < length; ++i)
    {
        arr[i] = i + 1;
    }
}

void printArray(int arr[], const int length)
{
    for (int i = 0; i < length; ++i)
    {
        cout << arr[i] << ' ';
    }
    cout << endl;
}

int main()
{
    const int length = 10;
    int arr[length]{};

    initializeArray(arr, length);
    printArray(arr, length);



    return 0;
}
*/
#pragma endregion
#pragma region LowLevelMethod
/*
void initializeArray(int *arr, const int length) {
    for (int i = 0; i < length; ++i) {
        *(arr + i) = i + 1;
    }
}

void printArray(int *arr, const int length) {
    for (int i = 0; i < length; ++i) {
        cout << *(arr + i) << ' ';
    }
    cout << endl;
}

int main() {
    const int length = 10;
    int arr[length]{};

    initializeArray(arr, length);
    printArray(arr, length);

    return 0;
}
*/
#pragma endregion

#pragma region ReturnPointer

//int* createArr(const int length) {
//    int *arr = new int[length]{}; // new - allocates memory in Heap
//    return arr;
//}
//
//void initializeArray(int *arr, const int length, bool isUser) {
//    if (!isUser)
//    {
//        for (int i = 0; i < length; ++i) {
//            *(arr + i) = i + 1;
//        }
//    }
//    else
//    {
//        for (int i = 0; i < length; ++i) {
//            cout << "Enter: " << i + 1 << " element";
//            cin >> *(arr + i);
//        }
//    }
//}
//
//void printArray(int *arr, const int length) {
//    for (int i = 0; i < length; ++i) {
//        cout << *(arr + i) << ' ';
//    }
//    cout << endl;
//}
//
//int main() {
//
//    int length{};
//    cout << "Enter length of arr: ";
//    cin >> length;
//
//    int* arr = createArr(length);
//
//    initializeArray(arr, length, false);
//    printArray(arr, length);
//
//    return 0;
//}


#pragma endregion

#pragma region Template

template <typename T>
T* createArr(const int length) // template function
{
    T* arr = new T[length];
    return arr;
}

int main()
{
    int* arr = createArr<int>(5);


//    char* arr2 = createArr<char>(5);




    return 0;
}

#pragma endregion

#pragma endregion

#pragma endregion
