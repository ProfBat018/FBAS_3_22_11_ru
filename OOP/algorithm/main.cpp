#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <ctime>

using namespace std;

bool isEven(int num) {
    return num % 2 == 0;
}

float countTaxes(float salary, float (*taxFuncs[])(float), int taxCount) {
    float taxes = 0;

    for (int i = 0; i < taxCount; i++) {
        taxes += taxFuncs[i](salary);
    }

    return taxes;
}

float tax1(float salary) {
    return salary * 0.05;
}

float tax2(float salary) {
    return 85.f;
}

float tax3(float salary) {
    return 15.f ;
}

int main() {

#pragma region Lambda

//    bool (*ptr)(int) = isEven;
//
//    bool (*ptr2)(int) = [](int num) {
//        return num % 2 == 0;
//    };

#pragma endregion
#pragma region WithoutAlgorithm

//    vector<int>* nums = new vector<int> {1, 2, 3, 4, 5};
//    vector<int>* newNums = new vector<int>;
//
//    for (int i = 0; i < nums->size(); i++) {
//        if (nums->at(i) % 2 == 0)
//            newNums->push_back(nums->at(i));
//    }


#pragma endregion
#pragma region WithAlgorithm

#pragma region WithoutLambda
/*
vector<int> *nums = new vector<int> {1, 2, 3, 4, 5};
vector<int> *newNums = new vector<int>;

// функция из библиотеки algorithm
// back_inserter - функция, которая возвращает итератор, который вставляет элементы в конец вектора
// predicate - указатель на функцию, которая возвращает true или false

copy_if(nums->begin(), nums->end(), back_inserter(*newNums), isEven);

for (int i = 0; i < newNums->size(); i++) {
    cout << newNums->at(i) << endl;
}

 */
#pragma endregion

#pragma region WithLambda

//vector<int> *nums = new vector<int>{1, 2, 3, 4, 5};
//vector<int> *newNum = new vector<int>{1, 2, 3, 4, 5};
//
//copy_if(nums->begin(), nums->end(), back_inserter(*newNum), [](int num) {
//    return num % 2 == 0;
//});

#pragma endregion

#pragma endregion
#pragma region Sort
/*
    srand(time(NULL));

    vector<int> *nums = new vector<int>;

    for (int i = 0; i < 10; i++) {
        nums->push_back(rand() % 10);
    }

    for (int num : *nums) {
        cout << num << " ";
    }
    cout << endl;

    sort(nums->begin(), nums->end());

    for (int num : *nums) {
        cout << num << " ";
    }
    cout << endl;
*/
#pragma endregion
#pragma region PointersToFunctionExample

float salary = 2000.f;

float (*taxFuncs[])(float) = {tax1, tax2, tax3};

int taxCount = 3;

cout << salary - countTaxes(salary, taxFuncs, taxCount) << endl;



#pragma endregion


    return 0;
}
