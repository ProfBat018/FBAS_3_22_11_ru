#include <iostream>
#include "StringLibrary.h"
using namespace std;


int main()
{
    char* name = new char[10] {"Elvin"};
    
    cout << getLength(name);


    return 0;
}

