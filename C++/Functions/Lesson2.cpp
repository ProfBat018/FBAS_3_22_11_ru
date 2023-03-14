#include <iostream>
#include "MyLib.h"

using namespace std;

void add(int& number) { // Здесь, & - Не принятие адреса, а передача по адресу
    number++;
}


int main()
{
    int num = 1;

    cout << num << endl;
    add(num);
    cout << num << endl;

    return 0;
}

