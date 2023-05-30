#include <iostream>
#include <string>

using namespace std;

//class Person {
//private:
//    uint16_t age{};
//public:
//    string name;
//    string surname;
//
//    Person() = default;
//    Person(string name, string surname, uint16_t age) {
//        this->name = name;
//        this->surname = surname;
//        this->age = age;
//    }
//
//    virtual void sayHello() {
//        cout << "Hello, my name is " << name << " " << surname << endl;
//    }
//};
//
//class Student : public Person {
//private:
//    float average{};
//public:
//
//    Student() = default;
//
//    Student(string name, string surname, uint16_t age, float average) : Person(name, surname, age) {
//        this->average = average;
//    }
//
//    void sayHello() override {
//        cout << "Hello, my name is " << name << " " << surname << " and I'm a student" << endl;
//    }
//};


class Transport {
public:
    virtual void move() {
        cout << "Transport is moving" << endl;
    }
};

class Car : public Transport {
public:
    void move() override {
        cout << "Car is moving" << endl;
    }
};

class Bicycle : public Transport {
public:
    void move() override {
        cout << "Bicycle is moving" << endl;
    }
};
int main() {

    Transport *transport = new Transport();
    transport->move();

    transport = new Car();
    transport->move();

    transport = new Bicycle();
    transport->move();


    return 0;
}
