#include <iostream> // <> - это системные библиотеки
#include "StringLib.h" // "" - это библиотеки, которые мы создаем

// "" - можно вызывать и системные библиотеки, но это не очень хорошо
// <> - можно вызывать только библиотеки, которые есть в системе
using namespace std;


int main() {

    char* name = new char[] {"Elvin"};

    cout << "Length: " << getLength(name) << endl;

    return 0;
}
