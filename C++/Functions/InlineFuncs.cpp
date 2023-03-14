#include <iostream>
using namespace std;

// inline function - функция, которая копируется в место вызова.
// inline - просьба компилятору на копирование этой функции.
// От того, что вы написали inline нет гарантий, что он скопирует содержимое.
// Есть несколько факторов...
// 1. Функция должна быть маленькой
// 2. Там не должно быть условий, циклов и других блочных элементов...

//inline void foo() {
//    cout << "Hello World" << endl;
//}


int sum(int number) {
    if(number == 0) {
        return 0 ;
    }
    return number + sum(number - 1);
}


int main()
{
    cout << sum(5);

//    foo(); // Вызов функции

    return 0;
}

