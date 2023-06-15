#include <iostream>
#include <string>
#include <cstring>

using namespace std;

class Car {
public:
    char* make{};
    char* model{};
    // default constructor
    Car() = default;

    // constructor with parameters
    Car(char* make, char* model) {
        this->make = make;
        this->model = model;
    }

    // copy constructor

    Car(Car& car) {
        this->make = car.make;
        this->model = car.model;

//        this->make = new char[strlen(car.make) + 1];
//        strcpy(this->make, car.make);
//        this->model = new char[strlen(car.model) + 1];
//        strcpy(this->model, car.model);
    }
};

int main() {

    Car* car1 = new Car(new char[] {"BMW"}, new char[] {"X5"});

    cout << car1->make << endl;
    cout << car1->model << endl;

    Car* car2 = new Car(*car1);

    car2->make = new char[] {"Mercedes"};
    car2->model = new char[] {"GL 350"};

    cout << car1->make << endl;
    cout << car1->model << endl;


    // char* make = new char[] {"BMW"};
    // char* model = new char[] {"X5"};

    // Car car1(make, model);

    // cout << car1.make << endl;
    // cout << car1.model << endl;

    // Car car2 = car1;

    // car2.make = new char[] {"Mercedes"};
    // car2.model = new char[] {"GL 350"};

    // cout << car1.make << endl;
    // cout << car1.model << endl;


    return 0;
}