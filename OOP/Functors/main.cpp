#include <iostream>
#include <string>
#include <vector>

using namespace std;

// Перегрузка оператора ()
#pragma region Part1

/*
class Person {
    string name;
    string surname;
    uint16_t age;
public:
    Person() = default;

    Person(const string& name, const string& surname, uint16_t age) {
        this->name = name;
        this->surname = surname;
        this->age = age;
    }

    void operator() (const Person& other) {
        cout << "Name: " << name << endl;
        cout << "Surname: " << surname << endl;
        cout << "Age: " << age << endl;
    }
};

class Car {};

int main() {

    Person *p1 = new Person("Baxa", "Mirzoyev", 17);
    Person p2("Isa", "Ismayilov", 16);

    (*p1)();
    p2();

    return 0;
}
*/

#pragma endregion

#pragma region Part2

class Expression {
    string text;
    vector<float>* nums{};
public:
    Expression() = default;

    Expression(const string& text) {
        this->text = text;
    }

    void operator() (const string& text) {
        // извлкаем числа из строки и вставляем в вектор
        // stof - преобразует строку в число с плавающей точкой
        nums = new vector<float>;
        string temp;
        for (char i : text) {
            if (i == ' ') {
                nums->push_back(stof(temp));
                temp = "";
            } else {
                temp += i;
            }
        }
        // извлекаем оператор
        char op = temp[0];
        temp = "";
        for (int i = 1; i < text.length(); i++) {
            temp += text[i];
        }

        // выполняем операцию
        float result = 0;

        switch (op) {
            case '+':
                for (float i : *nums) {
                    result += i;
                }
                break;
            case '-':
                for (float i : *nums) {
                    result -= i;
                }
                break;
            case '*':
                result = 1;
                for (float i : *nums) {
                    result *= i;
                }
                break;
            case '/':
                result = 1;
                for (float i : *nums) {
                    result /= i;
                }
                break;
            default:
                cout << "Error" << endl;
                break;
        }
    }
};


int main() {
    Expression e;
    e("1 2 3 4 5 +");

    return 0;
}
#pragma endregion

