#include <iostream>

using namespace std;

float addition(float n1, float n2) {
    return n1 + n2;
}

float subtraction(float n1, float n2) {
    return n1 - n2;
}

float multiplication(float n1, float n2) {
    return n1 * n2;
}

int main() {

    int num1{};
    int num2{};

    int choice{};
    cout << "Enter a choice\n"
            "1. Addition\n"
            "2. Subtraction\n"
            "3. Multiplication\n" << endl;
    cin >> choice;

    // массив указателей на функции
    float (*func_ptr[3])(float, float) = {addition, subtraction, multiplication};

    cout << "Enter two numbers: " << endl;
    cin >> num1 >> num2;
    
    cout << "Result: " << func_ptr[choice - 1](num1, num2) << endl;


    return 0;
}
