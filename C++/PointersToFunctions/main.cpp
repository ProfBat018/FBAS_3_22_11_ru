#include <iostream>
using namespace std;


#pragma region Part1

// Указатели на функции

//float countIncome(float salary) {
//    return salary * 0.05f;
//}
//
//float countDSMF() {
//    return 84.f;
//}
//
//float countITSDA() {
//    return 14.5f;
//}
//
//
//float countAllTaxes(float salary, float (*a)(float), float (*b)(), float (*c)()) {
//    return salary - (countIncome(salary) + countDSMF() + countITSDA());
//}

//int main() {
//
//    cout << countAllTaxes(3000, countIncome, countDSMF, countITSDA);
//
//    return 0;
//}
#pragma endregion


// create add, subtract, multiply, divide functions with twi int params


float add(int a, int b) {
    return a + b;
}

float subtract(int a, int b) {
    return a - b;
}

float multiply(int a, int b) {
    return a * b;
}

float divide(int a, int b) {
    return a / b;
}


int main()
{
    float (*arr[]) (int, int) = { add, subtract, multiply, divide };

    int choice{};

    int n1, n2{};

    cout << "Enter two nums" << endl;

    cin >> n1 >> n2;

    cout << "Enter choice: " << endl;

    cin >> choice;

    cout << arr[choice - 1](n1, n2);

    return 0;
}

