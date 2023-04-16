#include <iostream>

using namespace std;

struct Person {
    char *name = new char[20]{};
    char *surname = new char[20]{}; // {} - это инициализация.
    int age;

    void print() {
        cout << name << " " << surname << " " << age << endl;
    }
};