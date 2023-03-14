#include <iostream>

using namespace std;


int main() {
/*
    int a = 5;
    int b = 10;
    int c = a + b     => a and b - operand. + - operator
    Операторы
    1. Унарные: ++, --, &, *, !, ~
    2. Бинарные: +, -, *, /, %, >, <, <=, >=, !=, ==, &&, ||,  &, |, ^, <<, >>
    3. Тернарные
*/

//    int num1 = 3;
//    int num2 = 10;

//int num3 = num1 & num2;
//cout << num3;

//    int num3 = num1 | num2;
//    cout << num3;

//    int num3 = num1 ^ num2; // exceptible or
//    cout << num3;

//int num3 = num1 >> 2;
//cout << num3;


int num3 = ~5; // ~ NOR
cout << num3; // -(~(~N)+1) =>  -(N + 1)

// Создал переменную number
// number - укaзатель на int;
// number - находится в стэке, как и любая переменная
// данные number - находятся в heap.


#pragma region About_Pointers

//    int *number = new int(10);
//    cout << number << endl;     // адрес 10 в heap
//    cout << &number << endl;    // адрес самой переменной number в stack
//    cout << *(number) << endl;    // выйдет 10

//    int *arr = new int[5]{1, 2, 3, 4, 5};
//
//    for (int i = 0; i < 5; ++i) {
//        cout << arr + i << ' ' << *(arr + i) << endl; // арифметика указателей
//    }
#pragma endregion

    return 0;
}
