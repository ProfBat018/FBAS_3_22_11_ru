#include <iostream>
using namespace std;

//
//struct A {
//    long long a;
//    int b;
//    char c;
//};


struct A {
    char a;
    char c;
    int b;
};

int main() {
    A a;
    cout << sizeof(a) << endl;
    return 0;
}