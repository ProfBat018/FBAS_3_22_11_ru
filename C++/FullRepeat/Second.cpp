#include <iostream>
using namespace std;

void foo(int* arr, const int length, int& sum) {
    for (int i = 0; i < length; ++i) {
        sum += arr[i];
    }
}

int main() {

    int length{}, res{};
    cout << "Enter length: ";
    cin >> length;

    int *arr = new int[length]{};

    for (int i = 0; i < length; ++i) {
        arr[i] = i + 1;
    }

    foo(arr, length, res);

    cout << "Result is: " << res << endl;

    return 0;
}



