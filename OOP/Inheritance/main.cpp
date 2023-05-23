#include <iostream>
#include <string>

using namespace std;

struct Person {
public:
    string name;
    string surname;

    Person() = default;

    Person(int age, string name, string surname) {
        setAge(age);
        this->name = name;
        this->surname = surname;
    }

    int getAge() {
        return this->age;
    }

    void setAge(uint16_t age) {
        if (age >= 18 && age <= 120)
            this->age = age;
        else
            cout << "Invalid age" << endl;
    }

private:
    int age{};
};



struct Student {
    float gpa{};
};

int main() {
    Person person(130, "John", "Doe");

    cout << person.getAge() << endl;


    return 0;
}
