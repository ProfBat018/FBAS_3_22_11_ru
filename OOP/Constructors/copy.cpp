#include <iostream>
#include <string>
#include <cstring>

using namespace std;

class Car {
public:
    char* make{};
    char* model{};
    Car() = default;
    Car(char* make, char* model) {
        this->make = make;
        this->model = model;
    }

    Car(const Car& car) {
        //// костыльное решение

        // this->make = car.make;
        // this->model = car.model;
        
        // правильное решение
        this->make = new char[strlen(car.make) + 1]{};
        strcpy(this->make, car.make);

        this->model = new char[strlen(car.model) + 1]{};
        strcpy(this->model, car.model);
    }

    friend ostream& operator<<(ostream& os, const Car& car) {
        os << "make: " << car.make << '\n' << "model: " << car.model;
        return os;
    }
};

int main() {

    Car *car1 = new Car(new char[] {"BMW"}, new char[] {"X5"});

    // cout << "car1:\n" << *car1 << endl;

    // Car *car2 = new Car(*car1); // Конструктор копирования

    // cout << "car1:\n" << *car1 << endl;


    cout << "car1:\n" << *car1 << endl;

    Car *car2 = car1; // Конструктор копирования не вызывается

    car2->make[0] = 'A';

    cout << "car1:\n" << *car1 << endl;
    cout << "car2:\n" << *car2 << endl;


    return 0;
}