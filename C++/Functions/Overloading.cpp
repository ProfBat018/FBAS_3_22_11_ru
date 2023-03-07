#include <iostream>
using namespace std;

#pragma region Part1


//
//float add(float num1, float num2) {
//    return num1 + num2;
//}
//
//int add(int num1, int num2) {
//    return num1 + num2;
//}
//
//char add(char a, char b) {
//    return a + b;
//}

/*
void foo(int a, float b) {
    cout << "hello";
}

int foo(float b, int a) {
    cout << "hello";
    return 1;
}
*/


//int main() {

    // Сигнатура функции
    // 1. Название
    // 2. Возращаемый тип
    // 3. Параметры

    // Перегрузка функций - несколько функций с одним названием.
    // По каким параметрам бывает перегрузка
    // 1. Количество параметров
    // 2. Тип параметров
    // 3. Порядок параметров
    // ВНИМАНИЕ! Перегрузки по возвращаемому типу не бывает.


//    return 0;
//}

#pragma endregion

#pragma region Part2

template <typename T>
T* createArr(const int length) {
    T* arr = new T[length]{};
    return arr; // адрес первого элемента
}

template <typename T>
void initializeArr(T* arr, const int length) {
    for (int i = 0; i < length; ++i) {
        arr[i] = i + 1;
    }
}

template <typename T>
void printArr(T* arr, const int length) {
    for (int i = 0; i < length; ++i) {
        cout << arr[i] << ' ';
    }
}

int main()
{
    int length{};
    int* arr = nullptr;
    float* arr2 = nullptr;
    cout << "Enter length: ";
    cin >> length;

    arr = createArr<int>(length);
    arr2 = createArr<float>(length);
    initializeArr<int>(arr, length);
    initializeArr<float>(arr2, length);
    printArr<int>(arr, length);
    cout << endl;
    printArr<float>(arr2, length);


    return 0;
}
#pragma endregion