#include <iostream>
#include <string>

using namespace std;

class Person {
public:
    void foo() {
        cout << "Hello World";
    }
};

__forceinline void foo() {
    cout << "Hello World";
}

int main() {

    foo();

    return 0;
}
