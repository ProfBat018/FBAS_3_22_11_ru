#include <iostream>
using namespace std;


template <typename T>
T foo(T n1) {
    return n1;
}

int main()
{
    foo<int>(1);
    foo<double>(1.1);    

    return 0;
}
